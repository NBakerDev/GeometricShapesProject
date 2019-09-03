﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
   public class Parallelegram : Quadrilateral{

        public int Area() {
            return Side1 * Side2;
        }

        public Parallelegram(int side1, int side2) : base(side1, side2, side1, side2)  {


        }
    }
}
