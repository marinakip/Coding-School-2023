using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using FuelStation.Winforms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Winforms {
    public partial class ItemsForm : Form {
        private ItemService _itemService = new();
        public ItemsForm() {
            InitializeComponent();
        }


        private async void ItemsForm_Load(object sender, EventArgs e) {
            await LoadItemsAsync();
        }

        private async Task LoadItemsAsync() {
            try {
                IEnumerable<ItemListDto> items = await _itemService.GetItems();
                grvItems.DataSource = items.ToList();
            } catch (Exception ex) {
                MessageBox.Show($"Error loading items: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e) {
            RefreshItemList();
        }

        private async void RefreshItemList() {
            IEnumerable<ItemListDto> items = await _itemService.GetItems();
            grvItems.DataSource = items.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            ItemListDto selectedItem = GetSelectedItem();
            UpdateItemForm updateItemForm = new UpdateItemForm(selectedItem);
            updateItemForm.ShowDialog();
        }

        private ItemListDto GetSelectedItem() {
            DataGridViewRow selectedRow = grvItems.SelectedRows[0];
            ItemListDto selectedItem = (ItemListDto)selectedRow.DataBoundItem;
            return selectedItem;
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            ItemListDto selectedItem = GetSelectedItem();
            await _itemService.DeleteItem(selectedItem);
            RefreshItemList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            CreateItemForm createItemForm = new CreateItemForm();
            createItemForm.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

    }
}
