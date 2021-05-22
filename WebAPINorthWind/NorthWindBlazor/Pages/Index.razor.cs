using Microsoft.AspNetCore.Components;
using NorthWindBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindBlazor.Pages
{
    public partial class Index
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        List<Product> Products = new List<Product>();
        Product Product = new Product();
        string Message;
        MarkupString TBody;
        const string RequestUri = "api/products";

        async Task GetProducts()
        {
            try
            {
                var Response = await HttpClient.GetAsync(RequestUri);
                if (Response.IsSuccessStatusCode)
                {
                    Products = await Response.Content.ReadFromJsonAsync<List<Product>>();
                    SetProducts();
                }
                else
                {
                    await HandleResponse(Response);
                    Products = new List<Product>();
                    SetProducts();
                }
            }catch(Exception e)
            {
                Message = $"No se pudo obtener la información. {e.Message}";
                Products = new List<Product>();
                SetProducts();
            }
        }

        async Task ShowProducts()
        {
            Message = "Procesando ... ";
            await GetProducts();
            if (Products.Count > 0)
            {
                Message = $"{Products.Count} registros léidos";
            }
        }

        async void FindById()
        {
            try
            {
                Message = "Procesando ...";
                var Response = await HttpClient.GetAsync($"{RequestUri}/{Product.Id}");
                if(Response.IsSuccessStatusCode)
                {
                    Product = await Response.Content.ReadFromJsonAsync<Product>();
                    Message = $"Producto {Product.Id} encontrado";
                }
                else
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Message = $"Producto {Product.Id} no encontrado";
                        Product.Name = "";
                        Product.UnitPrice = null;
                    }
                    else
                    {
                        await HandleResponse(Response);
                    }
                }
            }catch(Exception e)
            {
                Message = $"No se pudo obtener la información {e.Message}";
                Product.Name = "";
                Product.UnitPrice = null;
            }

            StateHasChanged();
        }

        async Task AddProduct()
        {
            try
            {
                Message = "Procesando ... ";
                Product.Id = 0;
                var Response = await HttpClient.PostAsJsonAsync(RequestUri, Product);
                if (Response.IsSuccessStatusCode)
                {
                    Product = await Response.Content.ReadFromJsonAsync<Product>();
                    Message = $"Producto {Product.Id} agregado";
                    await GetProducts();
                }
                else
                {
                    await HandleResponse(Response);
                }
            }
            catch (Exception e)
            {
                Message = $"No se pudo agregar el producto. {e.Message}";
            }
            StateHasChanged();
        }

        async void UpdateProduct()
        {
            try
            {
                Message = "Procesando... ";
                var Response = await HttpClient.PutAsJsonAsync($"{RequestUri}/{Product.Id}", Product);
                if (Response.IsSuccessStatusCode)
                {
                    Message = $"Producto {Product.Id} modificado";
                    await GetProducts();
                }
                else
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Message = $"Producto {Product.Id} no encontrado";
                    }
                    else
                    {
                        await HandleResponse(Response);
                    }
                }
            }
            catch (Exception e)
            {
                Message = $"No se pudo modificar el producto. {e.Message}";
            }
            StateHasChanged();
        }

        async void DeleteProduct()
        {
            try
            {
                Message = "Procesando...";
                var Response = await HttpClient.DeleteAsync($"{RequestUri}/{Product.Id}");
                if (Response.IsSuccessStatusCode)
                {
                    Message = $"Producto {Product.Id} eliminado";
                    await GetProducts();
                }
                else
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Message = $"Producto {Product.Id} no encontrado";
                    }
                    else
                    {
                        await HandleResponse(Response);
                    }
                }
            }
            catch (Exception e)
            {
                Message = $"No se pudo eliminar el producto {e.Message}";
            }
            StateHasChanged();
        }

        void SetProducts()
        {
            var SB = new StringBuilder();
            foreach (var p in Products)
            {
                SB.Append("<tr>");
                SB.Append($"<td>{p.Id}</td>");
                SB.Append($"<td>{p.Name}</td>");
                SB.Append($"<td>{p.UnitPrice}</td>");
                SB.Append("</tr>");
            }
            TBody = (MarkupString)SB.ToString();
            StateHasChanged();
        }

        async Task HandleResponse(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.InternalServerError:
                    var Detail = await response.Content.ReadAsStringAsync();
                    Message = $"HTTP 500 Internal Server Error: {Detail}";
                    break;
                default:
                    (int Status, string Title, string Detail) ProblemDetails = await response.Content.ReadFromJsonAsync<(int, string, string)>();
                    Message = $"{ProblemDetails.Status}, {ProblemDetails.Title}, {ProblemDetails.Detail}";
                    break;
            }
        }
    }
}
