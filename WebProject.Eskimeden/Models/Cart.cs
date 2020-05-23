using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Eskimeden.Entity;

namespace WebProject.Eskimeden.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product,int quatity)
        {
            var line = _cardLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Product = product, Quantity = quatity });
            }
            else
            {
                line.Quantity += quatity;
            }
        }
        public void DeleteProduct(Product product)
        {
            //Sepettteki elemanı silme
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);

        }
        public double Total()
        {
            //Sepetteki ürünlerin fiyatlarının hesaplanması
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);

        }
        public void Clear()
        {
            _cardLines.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}