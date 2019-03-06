using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT username, rating, review_title, review_text, review_date FROM reviews ORDER BY review_date DESC", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Add(MapRowToActor(reader));
                }
            }

            return reviews;
        }

        private Review MapRowToActor(SqlDataReader reader)
        {
            return new Review()
            {
                Username = Convert.ToString(reader["username"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                ReviewText = Convert.ToString(reader["review_text"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"])
            };
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO reviews(username, rating, review_title, review_text, review_date)" +
                                               "VALUES(@username, @rating, @reviewTitle, @reviewText, @reviewDate)", conn);

                cmd.Parameters.AddWithValue("@username", newReview.Username);
                cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                cmd.Parameters.AddWithValue("@reviewTitle", newReview.ReviewTitle);
                cmd.Parameters.AddWithValue("@reviewText", newReview.ReviewText);
                cmd.Parameters.AddWithValue("@reviewDate", newReview.ReviewDate);

                cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
