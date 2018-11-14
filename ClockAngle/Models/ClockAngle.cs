using System;
using System.Collections.Generic;

namespace Clock
{
    public class ClockAngle
    {
        public static float Angles(float hour, float minute)
        {
         float clockAngle = (((60 * hour)-(11 * minute))/2); 
         return clockAngle;   
        }
     }
}