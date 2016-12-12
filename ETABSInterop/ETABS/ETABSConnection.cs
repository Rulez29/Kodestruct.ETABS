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
 
using ETABS2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kodestruct.ETABS.Interop 
{
    public static class ETABSConnection
    {
        public static cSapModel GetModel()
        {

            ETABS2016.cOAPI ETABSObject = (ETABS2016.cOAPI)Marshal.GetActiveObject("CSI.ETABS.API.ETABSObject");
            ETABS2016.cSapModel EtabsModel = ETABSObject.SapModel;

            return EtabsModel;
        }
    }
}