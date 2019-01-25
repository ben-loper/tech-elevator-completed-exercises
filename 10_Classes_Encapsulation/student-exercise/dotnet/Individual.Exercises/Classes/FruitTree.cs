using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        //Properties
        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            bool result = false;

            if(PiecesOfFruitLeft - numberOfPiecesToRemove >= 0)
            {
                result = true;
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
            }

            return result;
        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }
    }
}
