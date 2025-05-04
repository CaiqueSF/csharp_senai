using DeserializerClass;
using System.Net.Http.Headers;


namespace ApiServiceClass {
    public class ApiService {

        private readonly HttpClient _client; // Instância do HttpClient para fazer requisições HTTP.


        public ApiService() {
            _client = new HttpClient(); // Criação do objeto HttpClient
            _client.BaseAddress = new Uri("https://publica.cnpj.ws/"); // Define a URL base da API (https://www.receitaws.com.br/account/api)

            // Limpa cabeçalhos Accept existentes
            _client.DefaultRequestHeaders.Accept.Clear();

            // Define formato de resposta como JSON
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Adiciona token de autenticação no cabeçalho Authorization
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "3544904554b8e6e97db07f31ef72e74300dec8604a20a0b8bf35dc0ade385532");
        }


        public async Task<CnpjInfo> BuscarCnpjAsync(string cnpj_id) {

            try {
                // Limpar CNPJ para remover pontos, hífens e barras
                string cnpjFormatado = cnpj_id.Replace(" ", "").Replace(".", "").Replace("-", "").Replace("/", "");

                // 'await' suspende a execução até a conclusão da operação assíncrona, sem bloquear o thread.
                HttpResponseMessage response = await _client.GetAsync($"cnpj/{cnpjFormatado}");

                if (response.IsSuccessStatusCode) {
                    string conteudo = await response.Content.ReadAsStringAsync();
                    return Deserializer.DeserializeJson(conteudo);
                }
                else {
                    throw new Exception($"Erro: {response.StatusCode}");
                }
            }

            catch (Exception ex) {
                throw new Exception($"Exceção: {ex.Message}");
            }
        }
    }
}