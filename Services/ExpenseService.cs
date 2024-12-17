using ExpenseHound.Models;
using System.Net.Http.Json;
using MongoDB.Driver;

namespace ExpenseHound.Services
{
    public class ExpenseService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ExpenseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        //Get all expenses
        public async Task<List<Expense>> GetExpensesAsync()
        {
            var client = _httpClientFactory.CreateClient();

            return await client.GetFromJsonAsync<List<Expense>>("expenses");
        }


        //Get a single Expense by ID
        public async Task<Expense> GetExpenseAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();

            return await client.GetFromJsonAsync<Expense>($"expenses/{id}");
        }


        //Create a new expense
        public async Task<Expense> CreateExpenseAsync(Expense expense)
        {
            var client = _httpClientFactory.CreateClient();

            var response = await client.PostAsJsonAsync("expenses/create", expense);
            return await response.Content.ReadFromJsonAsync<Expense>();
        }


        //Update an existing expense
        public async Task UpdateExpenseAsync(string id, Expense expense)
        {
            var client = _httpClientFactory.CreateClient();

            await client.PutAsJsonAsync($"expenses/update/{id}", expense);
        }


        //Delete an existing expense
        public async Task DeleteExpenseAsync(string id)
        {
            var client = _httpClientFactory.CreateClient();

            await client.DeleteAsync($"expenses/delete/{id}");
        }
    }
}
