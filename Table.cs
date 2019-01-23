using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafringTable
{
    public class Table
    {
        private int[] cells = new int[Constants.TABLE_SIZE];

        public int this[int index]
        {
            get { return cells[index]; }
            set { cells[index] = value; }
        }

        public static bool operator ==(Table firstTable, Table secondTable)
        {
            for (int i = 0; i < Constants.TABLE_SIZE; i++)
            {
                if (firstTable.cells[i] != secondTable.cells[i]) return false;
            }
            return true;
        }
        public static bool operator !=(Table firstTable, Table secondTable)
        {
            for (int i = 0; i < Constants.TABLE_SIZE; i++)
            {
                if (firstTable.cells[i] != secondTable.cells[i]) break;
                if (i == 8)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
