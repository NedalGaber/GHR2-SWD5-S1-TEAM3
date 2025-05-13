using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace TechXpress.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>()
{
    new Product
    {
        Id = 1,
        ProductName = "Asus Tuf A15 Laptop",
        Price = 999.99m,
        Image = "Images/AssutTufA15.jpg",
        Description = "Powerful gaming laptop with AMD Ryzen 7, RTX 3060, 16GB RAM, and 512GB SSD. Durable and designed for high performance.",
        Rating = 4.6
    },
    new Product
    {
        Id = 2,
        ProductName = "Samsung Galaxy Tab A9",
        Price = 249.00m,
        Image = "Images/GalaxyTabA9.jpg",
        Description = "Affordable tablet with a 10.5-inch display, Octa-core processor, and long-lasting battery. Perfect for media and casual use.",
        Rating = 4.2
    },
    new Product
    {
        Id = 3,
        ProductName = "Samsung Galaxy Tab S10 Ultra",
        Price = 1199.00m,
        Image = "Images/GalaxyTabS10Ultra.jpg",
        Description = "Flagship tablet with AMOLED 14.6'' screen, S Pen, Snapdragon processor, and PC-like multitasking features.",
        Rating = 4.8
    },
    new Product
    {
        Id = 4,
        ProductName = "HP Victus Laptop",
        Price = 899.50m,
        Image = "Images/HpVictus.jpg",
        Description = "Gaming-ready laptop with Intel i7, GTX 1650, 16GB RAM, and 144Hz display. Sleek design and fast performance.",
        Rating = 4.4
    },
    new Product
    {
        Id = 5,
        ProductName = "HyperX Product",
        Price = 79.99m,
        Image = "Images/HyperX.jpg",
        Description = "Premium HyperX gaming headset with surround sound, noise-canceling mic, and comfortable memory foam ear cushions.",
        Rating = 4.5
    },
    new Product
    {
        Id = 6,
        ProductName = "iPhone 16",
        Price = 999.00m,
        Image = "Images/Iphone16.jpg",
        Description = "Latest Apple iPhone with A18 Bionic chip, advanced camera system, OLED display, and Dynamic Island.",
        Rating = 4.7
    },
    new Product
    {
        Id = 7,
        ProductName = "iPhone 16 Pro Max",
        Price = 1299.00m,
        Image = "Images/Iphone16PROMax.jpg",
        Description = "High-end iPhone with 6.9-inch OLED, triple-lens Pro camera, titanium frame, and up to 1TB storage.",
        Rating = 4.9
    },
    new Product
    {
        Id = 8,
        ProductName = "Lenovo Legion Laptop",
        Price = 1299.00m,
        Image = "Images/LenovoLegion.jpg",
        Description = "High-performance gaming laptop with RTX 3070, AMD Ryzen 9, and 165Hz display. Ideal for gaming and content creation.",
        Rating = 4.6
    },
    new Product
    {
        Id = 9,
        ProductName = "MacBook Pro",
        Price = 1999.00m,
        Image = "Images/macBookPro_.jpg",
        Description = "Apple MacBook Pro with M3 Pro chip, 16-inch Liquid Retina XDR display, and all-day battery life for professionals.",
        Rating = 4.8
    },
    new Product
    {
        Id = 10,
        ProductName = "MSI Thin 15 Laptop",
        Price = 1049.75m,
        Image = "Images/MsiThin15.jpg",
        Description = "Slim gaming laptop with Intel i7, RTX 4050, 144Hz display, and modern cooling technology.",
        Rating = 4.3
    },
    new Product
    {
        Id = 11,
        ProductName = "Redragon H350 Headset",
        Price = 49.00m,
        Image = "Images/RdragonH350.jpg",
        Description = "Comfortable gaming headset with virtual 7.1 surround sound, RGB lighting, and detachable microphone.",
        Rating = 4.4
    },
    new Product
    {
        Id = 12,
        ProductName = "Redragon H270 Headset",
        Price = 39.00m,
        Image = "Images/RedragonH270.jpg",
        Description = "Budget-friendly headset with clear stereo sound, adjustable headband, and inline volume control.",
        Rating = 4.1
    },
    new Product
    {
        Id = 13,
        ProductName = "Redragon K552 Keyboard",
        Price = 54.00m,
        Image = "Images/RedragonK552.jpg",
        Description = "Mechanical gaming keyboard with RGB lighting, blue switches, and compact tenkeyless design.",
        Rating = 4.6
    },
    new Product
    {
        Id = 14,
        ProductName = "RTX 4060 Graphics Card",
        Price = 399.00m,
        Image = "Images/RTX4060.jpg",
        Description = "Mid-range NVIDIA GPU with DLSS 3.0, 8GB GDDR6, and excellent 1080p/1440p gaming performance.",
        Rating = 4.5
    },
    new Product
    {
        Id = 15,
        ProductName = "RTX 4070 Graphics Card",
        Price = 599.00m,
        Image = "Images/RTX4070.jpg",
        Description = "Powerful GPU with 12GB GDDR6X, Ray Tracing, DLSS 3.0, and ideal for 1440p ultra and 4K gaming.",
        Rating = 4.7
    },
    new Product
    {
        Id = 16,
        ProductName = "Samsung Galaxy A55",
        Price = 449.00m,
        Image = "Images/SamsungA55.jpg",
        Description = "Mid-range smartphone with AMOLED 120Hz display, Exynos processor, and triple camera setup.",
        Rating = 4.3
    },
    new Product
    {
        Id = 17,
        ProductName = "Samsung Galaxy S25 Ultra",
        Price = 1299.00m,
        Image = "Images/SamsungS25Ultra.jpg",
        Description = "Flagship phone with 200MP camera, S Pen support, Snapdragon 8 Gen 4 chip, and premium design.",
        Rating = 4.9
    }
};

        public IActionResult viewProducts()
        {
          

            return View(products);
        }
        public IActionResult ProductDetails(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // or return a custom error view
            }

            return View(product);
        }

    }
}
