using System.Text;
using System.Text.Json;
using xmlEntegrasyon.Models;
using xmlEntegrasyon.Service;

List<Product_WC> product_WCs = [];

HttpClient httpClient = new();
WooCommerceService wooCommerceService = new(httpClient);
// wc deki mevcut tüm kategorileri çek
List<Category_WC> currentCategories = await wooCommerceService.GetCategoriesAsync();

using (var context = new SlnContext())
{
    Console.WriteLine("Uygulama Çalışıyor...");
    // Tüm ürünleri UrunlerXml tablosundan çekme
    var products = context.UrunlerXmls.ToList();
    Console.WriteLine("Ürünler Db'den çekildi...");

    int totalProdCount = products.Count;
    int currenProdCount = 1;
    foreach (var product in products)
    {
        Console.WriteLine($"Kalan Ürün Sayısı: {currenProdCount++}/{totalProdCount}");

        Console.WriteLine("Kategori kontrolü yapılıyor");
        // UrunAnaKategori değeri currentCategories içinde yoksa wc tarafında category oluşturacaz. varsa id'sini çekicez
        await FindOrCreateCategoryAsync(product.UrunAnaKategori);

        //bool checkProduct = await wooCommerceService.CheckProductAsync(product.UrunKodu);
        bool checkProduct = false;

        if (!checkProduct)
        {
            Console.WriteLine("Ürün WooCommerce için hazırlanıyor...");
            product_WCs.Add(new()
            {
                name = product.UrunAdi,
                type = string.IsNullOrEmpty(product.VaryantKodu) ? "simple" : "variable",
                description = product.UrunAciklama,
                short_description = product.UrunAciklama,
                categories = [],
                sku = product.UrunKodu,
                sale_price = product.SatisFiyati.ToString(),
                images = new[]
                {
                    product.Image1, product.Image2, product.Image3, product.Image4, product.Image5,
                    product.Image6, product.Image7, product.Image8, product.Image9, product.Image10,
                    product.Image11, product.Image12
                }
                .Where(imageUrl => !string.IsNullOrEmpty(imageUrl)) // Boş veya null olan URL'leri filtreliyoruz
                .Select(imageUrl => new Image_WC { src = imageUrl }) // Her bir URL'yi Image_WC nesnesine dönüştürüyoruz
                .ToArray()
            });

            if (product_WCs.Count == 20)
            {
                // 100 tane olduğunda woocommerce'e create gönder. listeyi sıfırla ve devam et
                await wooCommerceService.CreateBatchProduct(product_WCs);
                product_WCs.Clear();
            }
        }
        Console.WriteLine("--------------------------------------------------------------------------------");
    }
}


async Task FindOrCreateCategoryAsync(string urunAnaKategori)
{
    // eğer mevcut kategorilerde yoksa içeride create ederiz
    if (!currentCategories.Any(x => x.name == urunAnaKategori))
    {
        var createCategory = await wooCommerceService.CreateCategoryAsync(urunAnaKategori);
        await Console.Out.WriteLineAsync("Kategori oluşturuldu...");
        currentCategories.Add(createCategory);
    }
}


