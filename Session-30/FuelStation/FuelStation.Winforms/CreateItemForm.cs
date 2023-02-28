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
    public partial class CreateItemForm : Form {
        private ItemService _itemService = new();
        private ItemCreateDto _newItem = new ItemCreateDto();
        public CreateItemForm() {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e) {
           
            _newItem.Description = txtBoxDescription.Text;
            _newItem.Cost = convertToDecimal(textBoxCost.Text);
            _newItem.Price = convertToDecimal(textBoxPrice.Text); 
            _newItem.ItemType = (Model.Enumerations.ItemType) comboBoxItemType.SelectedItem;
            try {
                await _itemService.AddItem(_newItem);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show($"Error in Create New Item {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        private decimal convertToDecimal(string text) {
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

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e) {
            _newItem.ItemType = (Model.Enumerations.ItemType)comboBoxItemType.SelectedItem;
        }
    }
}
