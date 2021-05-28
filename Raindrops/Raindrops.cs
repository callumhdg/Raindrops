using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    public class RainDrops
    {
        public RainDrops()
        {
        }

        public string PlingPlangPlong(int input)
        {
            StringBuilder sb = new StringBuilder();

            //is input divisable by three?
            if (input % 3 == 0)
            {
                sb.Append("Pling");
            }

            //is input divisable by five?
            if (input % 5 == 0)
            {
                sb.Append("Plang");
            }

            //is input divisable by seven?
            if (input % 7 == 0)
            {
                sb.Append("Plong");
            }

            //if input is a factor return string of "Pling" and or "Plang" and or "Plong", else return input
            return (sb.Length != 0) ? sb.ToString() : input.ToString();

        }


    }
}
