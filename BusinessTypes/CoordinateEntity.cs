using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSample.BusinessTypes
{
    public class CoordinateEntity
    {
        public int TopY { get; set;  }
        public int BottomY { get; set; }
        public int TopX { get; set; }
        public int BottomX { get; set; }

        public string TriangleColumn { get; set; }

        public string TriangleRow { get; set; }

        public override string ToString()
        {
            return TriangleColumn.ToUpper()+ TriangleRow;
        }


    }
}