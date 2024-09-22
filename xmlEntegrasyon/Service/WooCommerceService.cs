using Microsoft.IdentityModel.Tokens;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace xmlEntegrasyon.Service
{
    public class WooCommerceService
    {
        private readonly string _baseUrl = "https://selenavm.com.tr/wp-json/wc/v3/";
        private readonly HttpClient _httpClient;

        // Constructor
        public WooCommerceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Kategorileri almak için metod
        public async Task<List<Category_WC>> GetCategoriesAsync()
        {
            // İstek URL'sini oluştur
            var requestUrl = $"{_baseUrl}products/categories";

            // Yeni HttpRequestMessage oluştur
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            // Basic Authentication header'ını ekliyoruz
            request.Headers.Add("Authorization", "Basic Y2tfODMwYWE5ZTlkMDAxNTg0NDNlYjM3ZTA1M2RkN2JhMjUyZjhkNTkyZjpjc183ZjJjNGU2MzgwZjg4ZjM3YzFjOWQ0NWI2OGVmZTNhZDhjY2QyMDI2");

            // İsteğe cookie ekliyoruz
            request.Headers.Add("Cookie", "mailpoet_page_view=%7B%22timestamp%22%3A1726997477%7D");

            // İsteği gönderiyoruz ve yanıtı alıyoruz
            var response = await _httpClient.SendAsync(request);

            // Başarılı olduğundan emin oluyoruz
            response.EnsureSuccessStatusCode();

            // Yanıtı string olarak alıp geri döndürüyoruz
            var responseBody = await response.Content.ReadAsStringAsync();

            var categories = JsonSerializer.Deserialize<List<Category_WC>>(responseBody);

            return categories;
        }

        // Yeni kategori oluşturmak için metod
        public async Task<Category_WC> CreateCategoryAsync(string categoryName)
        {
            // İstek URL'sini oluştur
            var requestUrl = $"{_baseUrl}products/categories";

            Category_WC category = new()
            {
                name = categoryName,
            };

            // Kategori bilgilerini JSON formatında oluşturuyoruz
            var jsonContent = JsonSerializer.Serialize(category);

            // HttpRequestMessage oluşturuyoruz (POST isteği)
            var request = new HttpRequestMessage(HttpMethod.Post, requestUrl);

            // Basic Authentication header'ını ekliyoruz
            request.Headers.Add("Authorization", "Basic Y2tfODMwYWE5ZTlkMDAxNTg0NDNlYjM3ZTA1M2RkN2JhMjUyZjhkNTkyZjpjc183ZjJjNGU2MzgwZjg4ZjM3YzFjOWQ0NWI2OGVmZTNhZDhjY2QyMDI2");

            // Body'yi JSON formatında ekliyoruz
            request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // İsteği gönderiyoruz ve yanıtı alıyoruz
            var response = await _httpClient.SendAsync(request);

            // Başarılı olduğundan emin oluyoruz
            response.EnsureSuccessStatusCode();

            // Yanıtı string olarak alıp geri döndürüyoruz
            var responseBody = await response.Content.ReadAsStringAsync();


            return JsonSerializer.Deserialize<Category_WC>(responseBody);
        }

        public async Task<bool> CheckProductAsync(string urunKodu)
        {
            var requestUrl = $"{_baseUrl}products?sku={urunKodu}";
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Add("Authorization", "Basic Y2tfODMwYWE5ZTlkMDAxNTg0NDNlYjM3ZTA1M2RkN2JhMjUyZjhkNTkyZjpjc183ZjJjNGU2MzgwZjg4ZjM3YzFjOWQ0NWI2OGVmZTNhZDhjY2QyMDI2");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            Product_WC[] prods = JsonSerializer.Deserialize<Product_WC[]>(responseBody);

            if (response.IsSuccessStatusCode)
                if (!prods.IsNullOrEmpty())
                    return true;

            return false;
        }

        public async Task<bool> CreateBatchProduct(List<Product_WC> prods)
        {
            BatchProduct_WC batchProcess = new()
            {
                create = prods
            };
            // İstek URL'sini oluştur
            var requestUrl = $"{_baseUrl}products/batch";


            // Kategori bilgilerini JSON formatında oluşturuyoruz
            var jsonContent = JsonSerializer.Serialize(batchProcess);

            // HttpRequestMessage oluşturuyoruz (POST isteği)
            var request = new HttpRequestMessage(HttpMethod.Post, requestUrl);

            // Basic Authentication header'ını ekliyoruz
            request.Headers.Add("Authorization", "Basic Y2tfODMwYWE5ZTlkMDAxNTg0NDNlYjM3ZTA1M2RkN2JhMjUyZjhkNTkyZjpjc183ZjJjNGU2MzgwZjg4ZjM3YzFjOWQ0NWI2OGVmZTNhZDhjY2QyMDI2");

            // Body'yi JSON formatında ekliyoruz
            request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            await Console.Out.WriteLineAsync("Toplu şekilde ürünler aktarılıyor...");
            // İsteği gönderiyoruz ve yanıtı alıyoruz
            var response = await _httpClient.SendAsync(request);

            // Başarılı olduğundan emin oluyoruz
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

    }
}
