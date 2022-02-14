using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        public void RetrieveReviewIsGood(List<ProductReview> review)
        {
            var recordData = (from products in review
                              where (products.Review == "Nice    ")
                              select products);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || Review : " + list.Review);
            }
        }
    }
}
    