using System;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiServiceClass {
    public class ApiService {

        private readonly HttpClient _client; // Instância do HttpClient para fazer requisições HTTP.

        public ApiService() {
            _client = new HttpClient(); // Criação do objeto HttpClient
            _client.BaseAddress = new Uri("https://api.api-futebol.com.br/v1/"); // Define a URL base da API

            // Limpa cabeçalhos Accept existentes
            _client.DefaultRequestHeaders.Accept.Clear();

            // Define formato de resposta como JSON
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Adiciona token de autenticação no cabeçalho Authorization
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "live_fc7b0f2dca726dba8293b454d9a884");
        }

        public async Task<string> BuscarClubeAsync(string nome) {

            try {
                //string nomeClubeFormatado = nome.Replace(" ", "").ToLower(); // Remove espaços e coloca em minúsculo

                // 'await' suspende a execução até a conclusão da operação assíncrona, sem bloquear o thread.
                HttpResponseMessage response = await _client.GetAsync($"times/{nome}");

                if (response.IsSuccessStatusCode) {
                    string conteudo = await response.Content.ReadAsStringAsync();
                    return conteudo;
                }
                else { return $"Erro: {response.StatusCode}"; }
            }

            catch (Exception ex){
                return $"Exceção: {ex.Message}";
            }
        }
    }
}
