namespace StevensGameCorner.Models
{
    public class ProductData
    {
        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel
                {
                    ProductID = 1,
                    ProductName = "Playing Cards",
                    ProductDescription = "A set of 52 playing cards",
                    ProductImage = "Cards.jpg",
                    ProductPrice = 3.99M
                },

                new ProductModel
                {
                    ProductID = 2,
                    ProductName = "Dice",
                    ProductDescription = "A set of various dice",
                    ProductImage = "Dice.jpg",
                    ProductPrice = 4.99M
                },

                new ProductModel
                {
                    ProductID = 3,
                    ProductName = "Dice Box",
                    ProductDescription = "A box to hold dice in",
                    ProductImage = "Dicebox.jpg",
                    ProductPrice = 25.99M
                },

                new ProductModel
                {
                    ProductID = 4,
                    ProductName = "Dice Bag",
                    ProductDescription = "A bag to hold dice in",
                    ProductImage = "Dicebag.jpg",
                    ProductPrice = 15.99M
                },


                new ProductModel
                {
                    ProductID = 5,
                    ProductName = "Poker Chips",
                    ProductDescription = "A set of poker chips",
                    ProductImage = "Pokerchips.jpg",
                    ProductPrice = 19.99M
                },

                new ProductModel
                {
                    ProductID = 6,
                    ProductName = "Table Mat",
                    ProductDescription = "A felt mat to put on a table to play on",
                    ProductImage = "Mat.jpg",
                    ProductPrice = 11.99M
                }
            };

            return products;
        }

        public static ProductModel GetProduct(int id)
        {
            List<ProductModel> products = ProductData.GetProducts();
            foreach (ProductModel product in products)
            {
                if (product.ProductID == id)
                {
                    return product;
                }
            }
            return new ProductModel();
        }
    }
}
