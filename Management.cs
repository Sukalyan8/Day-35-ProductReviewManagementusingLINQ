using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        public void SkipTopFiveRecords(List<ProductReview> review)
        {
            var recordData = (from products in review
                              select products).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : " + list.ProductId + " || User Id : " + list.UserId + " || Rating : " + list.Rating + " || Review : " + list.Review + " || Is Like : " + list.isLike);
            }
        }
    }
}