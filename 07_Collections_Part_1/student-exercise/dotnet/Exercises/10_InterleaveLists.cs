using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given two lists of Integers, interweave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> resultList = new List<int>();

            int i = 0;

            if(listOne.Count == listTwo.Count)
            {
                for (; i < listOne.Count; i++)
                {
                    resultList.Add(listOne[i]);
                    resultList.Add(listTwo[i]);
                }

            } else if(listTwo.Count > listOne.Count)
            {
                for(; i < listOne.Count; i++)
                {
                    resultList.Add(listOne[i]);
                    resultList.Add(listTwo[i]);
                }
                
                while(i < listTwo.Count)
                {
                    resultList.Add(listTwo[i]);
                    i++;
                }

            } else if(listTwo.Count < listOne.Count)
            {
                for (; i < listTwo.Count; i++)
                {
                    resultList.Add(listOne[i]);
                    resultList.Add(listTwo[i]);
                }

                while (i < listOne.Count)
                {
                    resultList.Add(listOne[i]);
                    i++;
                }
            }
            

            return resultList;
        }
    }
}
