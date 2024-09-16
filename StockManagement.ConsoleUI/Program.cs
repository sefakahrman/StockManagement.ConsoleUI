
using StockManagement.ConsoleUI;


List<Product> products = new List<Product>()
{
    new Product(1,"Beymen Takım Elbise",15000,250),
    new Product(2,"Prada Çanta",60000,10),
    new Product(3,"Hk Vision Drone",400000,25),
    new Product(4,"Dyson Süpürge",32000,200),
    new Product(5,"Karaca Vazo",500,1000),
    new Product(6,"Kütahya Porselen Ayna",1500,200),
    new Product(7, "Adidas Futbol Topu",5000,1254),
    new Product(8,"Delta Yoga Matı",2000,531)
};


List<Category> categories = new List<Category>()
{
    new Category(1,"Elbise","Elbise Açıklaması"),
    new Category(2,"Elektronik","Elektronik Açıklama"),
    new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
    new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),
};

ShowTitle("ÜRÜNLER");
ShowListAllProducts();
ShowTitle("KATEGORİLER");
ShowAllCategories();
AddNewProduct();


void AddNewProduct()
{

    bool isUnique = true;

    ShowTitle("Ürün Ekleme ve Listeleme");
    Console.WriteLine("Ürünün Id'si: ");
    int id = int.Parse(Console.ReadLine());

    foreach (Product product in products)
    {
        if (product.Id == id)
        {
            isUnique = false;
            break;
        }
    }
    if (!isUnique)
    {
        Console.WriteLine($"Id alanı benzersiz olmalıdır : {id}");
        return;
    }

    Console.WriteLine("Ürünün İsmi: ");
    string name = Console.ReadLine();

    Console.WriteLine("Ürünün Fiyatı: ");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Ürünün Stok Adedi: ");
    int stock = int.Parse(Console.ReadLine());


    Product addNewProduct = new Product(id, name, price, stock);

    ShowListAllProducts();

}

void ShowListAllProducts()
{
    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
}

void ShowAllCategories()
{
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void ShowTitle(string title)
{
    Console.WriteLine($"\n-------{title}-------");
}


