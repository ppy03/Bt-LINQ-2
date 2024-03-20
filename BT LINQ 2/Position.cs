using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LINQ_2
{
    class Position
    {
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public static List<Position> GetPositions()
        {
            return new List<Position>() {
                new Position {PositionID = 1, PositionName = "Phong A"},
                new Position {PositionID =  2, PositionName = "Phong B"},
                new Position {PositionID = 3 ,PositionName = "Phong C" },
                new Position {PositionID = 4 ,PositionName = "Phong D" },
                new Position {PositionID = 5 ,PositionName = "Phong E" },
            };
        }
    }
    

}
