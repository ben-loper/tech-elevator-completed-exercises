using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {
        private int _numOfUniqueBooksInSeries = 0;

        private int _booksRemovedFromCart = 0;

        private const decimal _CostOfBook = 8;

        public decimal GetCost(int[] books)
        {
            List<int> listOfBooks = new List<int>();

            listOfBooks.AddRange(books);

            decimal total = 0;

            total = GetTotal(listOfBooks);

            return total;
        }


        private decimal GetTotal(List<int> books)
        {
            decimal total = 0;

            int totalNumberOfBooksInCart = 0;

            foreach (int numOfBooks in books)
            {
                totalNumberOfBooksInCart += numOfBooks;
            }

            while (totalNumberOfBooksInCart > 0)
            {
                decimal discountInSeries = DiscountInSeries(books);

                total += _numOfUniqueBooksInSeries * (_CostOfBook - (_CostOfBook * discountInSeries));
                
                totalNumberOfBooksInCart -= _booksRemovedFromCart;
            }

            return total;
        }

        private decimal DiscountInSeries(List<int> books)
        {
            decimal discountInSeries = 0;
            _numOfUniqueBooksInSeries = 0;
            _booksRemovedFromCart = 0;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i] > 0)
                {
                    _numOfUniqueBooksInSeries++;
                    books[i]--;
                }
            }

            discountInSeries = DetermineDiscount(_numOfUniqueBooksInSeries);

            _booksRemovedFromCart += _numOfUniqueBooksInSeries;

            return discountInSeries;
        }


        private void GetNumberOfUniqueBooks(List<int> books)
        {
            _numOfUniqueBooksInSeries = 0;

            for (int i = 0; i < books.Count; i++)
            {
                if(books[i] > 0)
                {
                    _numOfUniqueBooksInSeries++;
                    books[i]--;
                }
            }
        }
        
        private decimal DetermineDiscount(int numOfUniqueBooks)
        {
            decimal discount = 0;

            if (numOfUniqueBooks >= 5)
            {
                discount = 0.25m;
            }
            else if (numOfUniqueBooks >= 4)
            {
                discount = 0.20m;
            }
            else if (numOfUniqueBooks >= 3)
            {
                discount = 0.10m;
            }
            else if (numOfUniqueBooks >= 2)
            {
                discount = 0.05m;
            }

            return discount;
        }
    }
}
