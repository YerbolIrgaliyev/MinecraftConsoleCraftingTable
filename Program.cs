using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace CrafringTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipes recipes = new Recipes();
            Table userTable = new Table();

            string tableFence = "#######";
            string tableCells = "# # # #";

            while (true)
            {
                Clear();
                WriteLine("Верстак майнкрафта: ");

                for (int j = 0; j < 3; j++)
                {
                    WriteLine(tableFence);
                    WriteLine(tableCells);
                }
                WriteLine(tableFence);

                for (int i = 0, y = 2, x = 1; i < Constants.TABLE_SIZE; i++)
                {
                    SetCursorPosition(x, y);
                    x += Constants.CURSOR_STEP;
                    if (x > Constants.MAX_POS_X)
                    {
                        y += Constants.CURSOR_STEP;
                        x = Constants.DEFAULT_POS_X;
                    }

                    ConsoleKeyInfo key = ReadKey();
                    char keyChar = key.KeyChar;


                    if (keyChar == 27) break;
                    else if (keyChar == 'Д' || keyChar == 'д' || keyChar == 'L' || keyChar == 'l')
                    { userTable[i] = Constants.WOOD; Write("\bД\b"); }
                    else if (keyChar == 'К' || keyChar == 'к' || keyChar == 'R' || keyChar == 'r')
                    { userTable[i] = Constants.STONE; Write("\bК\b"); }
                    else if (keyChar == 'З' || keyChar == 'з' || keyChar == 'P' || keyChar == 'p')
                    { userTable[i] = Constants.GOLD; Write("\bЗ\b"); }
                    else if (keyChar == 'П' || keyChar == 'п' || keyChar == 'G' || keyChar == 'g')
                    { userTable[i] = Constants.STICK; Write("\bП\b"); }
                    else if (keyChar == 'Ж' || keyChar == 'ж' || keyChar == ';' || keyChar == ':')
                    { userTable[i] = Constants.IRON; Write("\bЖ\b"); }
                    else
                    {
                        userTable[i] = Constants.NOTHING;
                        Write("\b \b");
                    }





                }
                SetCursorPosition(0, Constants.TABLE_SIZE);

                string builtedItem = Recipes.Build(recipes, userTable);
                WriteLine("Вы получили: \"{0}\"", builtedItem);

                ReadLine();
            }

        }
    }
}
