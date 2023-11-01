using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPFDiFrango.Models;
using WPFDiFrango.Models.Dto;

namespace WPFDiFrango
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:5000/api/") //change if different port/url
            };
        }

        //PEDIDOS
        internal async Task<List<Pedido>> GetPedidoByCliente(int id)
        {
            var response = await _httpClient.GetAsync("pedidos/cliente/" + id);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Pedido>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal async Task<List<Pedido>> GetFritosHoje()
        {
            var response = await _httpClient.GetAsync("Pedidos/hoje/frito");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Pedido>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal async Task<List<Pedido>> GetAssadosHoje()
        {
            var response = await _httpClient.GetAsync("pedidos/hoje/assado_outro");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Pedido>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal bool PostPedido(PedidoDtoCliente pedido)
        {
            var response = _httpClient.PostAsync("pedidos/cliente", new StringContent(JsonConvert.SerializeObject(pedido), Encoding.UTF8, "application/json")).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        internal bool PutPedido(int pedidoId, PedidoDto pedidoDto)
        {
            var teste = new StringContent(JsonConvert.SerializeObject(pedidoDto), Encoding.UTF8, "application/json");
            var response = _httpClient.PutAsync("Pedidos/" + pedidoId, teste).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal bool DeletePedido(Pedido pedido)
        {
            var response = _httpClient.DeleteAsync("pedidos/" + pedido.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal bool MarcarPedido(Pedido pedido)
        {
            var response = _httpClient.PostAsync("pedidos/marcar/" + pedido.Id, new StringContent(JsonConvert.SerializeObject(pedido), Encoding.UTF8, "application/json")).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        //CLIENTES


        internal async Task<List<Cliente>> GetClientes()
        {
            var response = await _httpClient.GetAsync("cliente");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Cliente>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal async Task<List<Cliente>> GetClienteByTelefoneOrNome(string str)
        {
            var response = await _httpClient.GetAsync("cliente/find/" + str);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Cliente>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        internal bool PutCliente(Cliente cliente)
        {
            var response = _httpClient.PutAsync("cliente/" + cliente.Id, new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json")).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        //PRODUTOPEDIDOS
        //PRODUTOS

        internal async Task<List<Produto>> GetProdutosAsync()
        {
            var response = await _httpClient.GetAsync("produto");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsAsync<List<Produto>>();
                return content;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
