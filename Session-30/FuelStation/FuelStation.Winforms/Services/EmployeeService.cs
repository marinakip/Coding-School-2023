using FuelStation.Web.Blazor.Shared.EmployeeDataTranferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Winforms.Services {
    public class EmployeeService {
        private readonly HttpClient _httpClient;
        public EmployeeService() {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<EmployeeListDto>> GetEmployees() {

            try {
                var response = await _httpClient.GetAsync("http://localhost:5061/employee");
                var employeeList = await response.Content.ReadAsAsync<List<EmployeeListDto>>();
                return employeeList;
            } catch (Exception ex) {
                MessageBox.Show($"Error in GetEmployees: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<EmployeeEditDto> GetEmployeeById(Guid Id) {
            try {
                //EmployeeEditDto employee = await _httpClient.GetFromJsonAsync<EmployeeEditDto>($"employee/{Id}");
                var response = await _httpClient.GetAsync($"http://localhost:5061/employee/{Id}");
                var employee = await response.Content.ReadAsAsync<EmployeeEditDto>();
                return employee;

            } catch (Exception ex) {
                MessageBox.Show($"Error in GetEmployeeById: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task AddEmployee(EmployeeCreateDto employee) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PostAsJsonAsync("http://localhost:5061/employee/", employee);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in AddEmployee: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateEmployee(EmployeeEditDto employee) {
            HttpResponseMessage? response = null;
            response = await _httpClient.PutAsJsonAsync("http://localhost:5061/employee/", employee);
            try {
                response.EnsureSuccessStatusCode();
            } catch (Exception ex) {
                MessageBox.Show($"Error in UpdateEmployee: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteEmployee(EmployeeListDto employee) {
            DialogResult result = MessageBox.Show($"Delete employee {employee.Name} {employee.Surname}. Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    var response = await _httpClient.DeleteAsync($"http://localhost:5061/employee/{employee.Id}");
                    response.EnsureSuccessStatusCode();
                } catch (Exception ex) {
                    MessageBox.Show($"Error in DeleteEmployee: {ex.Message}");
                    throw new Exception(ex.Message);
                }
            } else {
                MessageBox.Show($"Delete Employee was Canceled");
            }
        }
    }
}
