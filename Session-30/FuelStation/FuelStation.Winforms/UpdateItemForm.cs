using FuelStation.Model.Enumerations;
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
        private ItemListDto _selectedItem { get; set; }
        private ItemEditDto _updatedItem = new();

       
        public UpdateItemForm(ItemListDto selectedItem) {
            _selectedItem = selectedItem;
            InitializeComponent();          
        }
    

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e) {
            ItemType selectedItemType;
            if (Enum.TryParse(comboBoxItemType.SelectedItem.ToString(), out selectedItemType)) {
                // comboBoxItemType.SelectedItem = selectedItemType;
                _updatedItem.ItemType = selectedItemType;
            } else {
                MessageBox.Show("This selection is invalid");
                throw new Exception("Selected item is not a valid ItemType");
            }
        }

        private async void btnOK_Click(object sender, EventArgs e) {

            //Id = _selectedItem.Id,
            //Description = _selectedItem.Description,
            //ItemType = _selectedItem.ItemType,
            //Cost = _selectedItem.Cost,
            //Price = _selectedItem.Price 
            _updatedItem.Id = _selectedItem.Id;
            _updatedItem.Description = txtBoxDescription.Text;
            _updatedItem.Code = textBoxCode.Text;
            _updatedItem.Cost = ConvertToDecimal(textBoxCost.Text);
            _updatedItem.Price = ConvertToDecimal(textBoxPrice.Text);
            
            try {
                await _itemService.UpdateItem(_updatedItem);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error in Update Item {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private decimal ConvertToDecimal(string text) {
            decimal number;
            if (decimal.TryParse(text, out number)) {
                return number;
            } else {
                MessageBox.Show($"Error in TryParse number, couldn't convert");
                throw new Exception("Error in TryParse number, couldn't convert");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void UpdateItemForm_Load(object sender, EventArgs e) {
            txtBoxDescription.Text = _selectedItem.Description;
            textBoxCode.Text = _selectedItem.Code;
            textBoxCode.Enabled = false;
            textBoxCost.Text = _selectedItem.Cost.ToString();
            textBoxPrice.Text = _selectedItem.Price.ToString();      
            comboBoxItemType.Text = _selectedItem.ItemType.ToString();
            //comboBoxItemType.SelectedItem = _selectedItem.ItemType.ToString();
            comboBoxItemType.Items.AddRange(Enum.GetNames(typeof(ItemType)));
        }
    }
}
