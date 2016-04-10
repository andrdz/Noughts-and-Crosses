using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestGame
{
    class PlayingField
    {
        public static readonly PlayingElements[,] quadrates = new PlayingElements[3, 3];
        public static readonly PlayingElements[,] elements = new PlayingElements[3, 3]; //хрестики та нолики

        public PlayingField()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    quadrates[i, j] = new PlayingElements(i * 200, j * 200);
                    elements[i, j] = new PlayingElements(-1, -1);
                }
        }

        public static bool Check(int i, int j, string NameOfElement)
        {
            bool result = false;
            int ForCheck = 0;
            for (int n = 0; n < 3; n++)
                if (elements[i, n].NameOfElement == NameOfElement)
                    ForCheck++;

            if (ForCheck == 3)
                result = true;

            ForCheck = 0;

            if (result != true)
                for (int n = 0; n < 3; n++)
                    if (elements[n, j].NameOfElement == NameOfElement)
                        ForCheck++;

            if (ForCheck == 3)
                result = true;


            ForCheck = 0;

            if (result != true)
                for (int n = 0; n < 3; n++)
                    if (elements[2-n, n].NameOfElement == NameOfElement)
                        ForCheck++;

            if (ForCheck == 3)
                result = true;

            ForCheck = 0;

            if (result != true && i == j)
                for (int n = 0; n < 3; n++)
                    if (elements[n, n].NameOfElement == NameOfElement)
                        ForCheck++;

            if (ForCheck == 3)
                result = true;

            return result;
        }

        public static bool GameOver()
        {
            bool result = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (elements[i, j].NameOfElement == "")
                        result = false;
            return result;
        }
    }
}
