using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        public void RetrieveProductId10WithRating(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.ProductId == 10)
                              orderby products.Rating descending
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Rating : " + list.Rating);
            }
        }
    }
}
    