using FuelStation.Web.Blazor.Shared.CustomerDataTransferObjects;
using FuelStation.Web.Blazor.Shared.ItemDataTransferObjects;
using FuelStation.Winforms.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.Winforms {
    public partial class UpdateItemForm : Form {
        private ItemService _itemService = new();
        public ItemListDto SelectedItem { get; set; }
        public UpdateItemForm() {
            InitializeComponent();
        }

        public UpdateItemForm(ItemListDto selectedItem) {
            InitializeComponent();
            SelectedItem = selectedItem;
            txtBoxDescription.Text = selectedItem.Description;
            textBoxCost.Text = selectedItem.Cost.ToString();
            textBoxPrice.Text = selectedItem.Price.ToString();
            comboBoxItemType.SelectedItem = selectedItem.ItemType;
        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e) {
           // int selectedIndex = comboBoxItemType.SelectedIndex;
          //  string selectedValue = comboBoxItemType.SelectedItem.ToString();
            SelectedItem.ItemType = (Model.Enumerations.ItemType) comboBoxItemType.SelectedItem;               
        }

        private async void btnOK_Click(object sender, EventArgs e) {
            ItemEditDto updatedItem = new ItemEditDto {
                Id = SelectedItem.Id,
                Description = SelectedItem.Description,
                ItemType = SelectedItem.ItemType,
                Cost = SelectedItem.Cost,
                Price = SelectedItem.Price
            };
            try {
                await _itemService.UpdateItem(updatedItem);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error in Update Item {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
