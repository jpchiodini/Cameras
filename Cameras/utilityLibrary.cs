using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class utilityLibrary
    {
        //finds the position of a subarray in an array
        public int subarrayIndex(byte[] buffer, byte[] subarray, int currentPos)
        {
            //length of the part to search
            while (currentPos<buffer.Length)
            {
                int pos; 
                    if((pos = Array.IndexOf(buffer, subarray[0], currentPos)) == -1)
                    {
                        break;
                    }
                int ii;

                for (ii = 0; ii < subarray.Length; ii++, pos++)
                {
                    //if its not the complete substring
                    if (subarray[ii] != buffer[pos])
                    {
                        break;
                    }

                }
                if (ii == subarray.Length)
                {
                    return pos - subarray.Length;
                }
                else
                {
                    pos++;
                    currentPos = pos;
                }
            }
            return -1;
        }
    }
}
