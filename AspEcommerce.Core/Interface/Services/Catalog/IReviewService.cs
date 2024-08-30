using AspEcommerce.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspEcommerce.Core.Interface.Services.Catalog
{
    public interface IReviewService
    {
        /// <summary>
        /// Get review using product id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<Review> GetReviewsByProductId(Guid productId);

        /// <summary>
        /// Get review using product id and user id
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Review GetReviewByProductIdUserId(Guid productId, Guid userId);

        /// <summary>
        /// Insert review
        /// </summary>
        /// <param name="review"></param>
        /// <returns></returns>
        void InsertReview(Review review);

        /// <summary>
        /// Update review
        /// </summary>
        /// <param name="review"></param>
        void UpdateReview(Review review);
    }
}
