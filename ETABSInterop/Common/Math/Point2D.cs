﻿#region Copyright
   /*Copyright (C) 2015 Konstantin Udilovich

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   */
#endregion
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kodestruct.ETABS.Interop.Common.Mathematics
{
    public class Point2D
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point2D()
        {

        }

        public Point2D(string Name, double X, double Y)
        {
            this.Name = Name;
            this.X = X;
            this.Y = Y;
        }

        public Point2D(double X, double Y): this("", X,Y)
        {

        }
    }
}
