using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrafringTable
{
    public class Recipes
    {
        public Table woodenPickaxe = new Table
        {
            [0] = Constants.WOOD,
            [1] = Constants.WOOD,
            [2] = Constants.WOOD,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table ironPickaxe = new Table
        {
            [0] = Constants.IRON,
            [1] = Constants.IRON,
            [2] = Constants.IRON,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table goldenPickaxe = new Table
        {
            [0] = Constants.GOLD,
            [1] = Constants.GOLD,
            [2] = Constants.GOLD,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table stonePickaxe = new Table
        {
            [0] = Constants.STONE,
            [1] = Constants.STONE,
            [2] = Constants.STONE,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };

        public Table woodenAxe = new Table
        {
            [0] = Constants.WOOD,
            [1] = Constants.WOOD,
            [2] = Constants.NOTHING,
            [3] = Constants.WOOD,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table stoneAxe = new Table
        {
            [0] = Constants.STONE,
            [1] = Constants.STONE,
            [2] = Constants.NOTHING,
            [3] = Constants.STONE,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table ironAxe = new Table
        {
            [0] = Constants.IRON,
            [1] = Constants.IRON,
            [2] = Constants.NOTHING,
            [3] = Constants.IRON,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table goldenAxe = new Table
        {
            [0] = Constants.GOLD,
            [1] = Constants.GOLD,
            [2] = Constants.NOTHING,
            [3] = Constants.GOLD,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };

        public Table woodenMattock = new Table
        {
            [0] = Constants.WOOD,
            [1] = Constants.WOOD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table stoneMattock = new Table
        {
            [0] = Constants.STONE,
            [1] = Constants.STONE,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table ironMattock = new Table
        {
            [0] = Constants.IRON,
            [1] = Constants.IRON,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table goldenMattock = new Table
        {
            [0] = Constants.GOLD,
            [1] = Constants.GOLD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };

        public Table woodenShovel = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.WOOD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table stoneShovel = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.STONE,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table ironShovel = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.IRON,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table goldenShovel = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.GOLD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STICK,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };

        public Table woodenSword = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.WOOD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.WOOD,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table stoneSword = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.STONE,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.STONE,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table ironSword = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.IRON,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.IRON,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };
        public Table goldenSword = new Table
        {
            [0] = Constants.NOTHING,
            [1] = Constants.GOLD,
            [2] = Constants.NOTHING,
            [3] = Constants.NOTHING,
            [4] = Constants.GOLD,
            [5] = Constants.NOTHING,
            [6] = Constants.NOTHING,
            [7] = Constants.STICK,
            [8] = Constants.NOTHING
        };

        public Table stove = new Table
        {
            [0] = Constants.STONE,
            [1] = Constants.STONE,
            [2] = Constants.STONE,
            [3] = Constants.STONE,
            [4] = Constants.NOTHING,
            [5] = Constants.STONE,
            [6] = Constants.STONE,
            [7] = Constants.STONE,
            [8] = Constants.STONE
        };

        public static string Build(Recipes recipes, Table table)
        {
            if (table == recipes.goldenAxe) return "Золотой топор";
            if (table == recipes.goldenMattock) return "Золотая мотыга";
            if (table == recipes.goldenPickaxe) return "Золотая кирка";
            if (table == recipes.goldenShovel) return "Золотая лопата";
            if (table == recipes.goldenSword) return "Золотой меч";

            if (table == recipes.ironAxe) return "Железный топор";
            if (table == recipes.ironSword) return "Железный меч";
            if (table == recipes.ironMattock) return "Железная мотыга";
            if (table == recipes.ironPickaxe) return "Железная кирка";
            if (table == recipes.ironShovel) return "Железная лопата";

            if (table == recipes.stoneAxe) return "Каменный топор";
            if (table == recipes.stoneSword) return "Каменный меч";
            if (table == recipes.stoneMattock) return "Каменная мотыга";
            if (table == recipes.stonePickaxe) return "Каменная кирка";
            if (table == recipes.stoneShovel) return "Каменная лопата";

            if (table == recipes.woodenAxe) return "Деревянный топор";
            if (table == recipes.woodenSword) return "Деревянный меч";
            if (table == recipes.woodenMattock) return "Деревенная мотыга";
            if (table == recipes.woodenPickaxe) return "Деревенная кирка";
            if (table == recipes.woodenShovel) return "Деревенная лопата";

            if (table == recipes.stove) return "Печка";

            return "Ничего";
        }

    }
}
