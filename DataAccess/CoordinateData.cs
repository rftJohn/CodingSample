using CodeSample.BusinessTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSample.DataAccess
{
    public class CoordinateData
    {
        public static CoordinateEntity GetCoordinateEntity(int column, string row)
        {
            var _return = new CoordinateEntity();
            _return.TriangleColumn = column.ToString();
            _return.TriangleRow = row.ToUpper();
            int r = GetRowNumeric(row); 

            if (column % 2 == 0)
            {
                // even
                _return.TopY = (column - 1) * 10;
                _return.BottomY = -1;

                _return.TopX = _return.TopY + 10;
                _return.BottomX = r * 10;


            }
            else
            {
                // odd

                _return.TopY = (column - 1) * 10;
                _return.BottomY = r + 10;

                _return.TopX = -1;
                _return.BottomX = r * 10;
             }


                return _return; 
        }

        private static int GetRowNumeric(string row)
        {
            int _return = 0; 
            switch(row.ToUpper())
            {
                case "A":
                    _return = 1;
                    break;
                case "B":
                    _return = 2;
                    break;
                case "C":
                    _return = 3;
                    break;
                case "D":
                    _return = 4;
                    break;
                case "E":
                    _return = 5;
                    break;
                case "F":
                    _return = 6;
                    break;
            }

            return _return; 
        }
      
    }
}