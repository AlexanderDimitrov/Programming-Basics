using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15.BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.Parse(Console.ReadLine());
            uint result = 0;
            uint nRigptP = a >> 3;
            uint bit3 = nRigptP & 1;
            nRigptP = a >> 24;
            uint bit24 = nRigptP & 1;
            nRigptP = a >> 4;
            uint bit4 = nRigptP & 1;
            nRigptP = a >> 25;
            uint bit25 = nRigptP & 1;
            nRigptP = a >> 5;
            uint bit5 = nRigptP & 1;
            nRigptP = a >> 26;
            uint bit26 = nRigptP & 1;
            if (bit3 == 0 && bit24 == 1)
            {
                int mask = ~(1 << 24);      //bit24=0;  
                result = a & (uint)mask;
                mask = 1 << 3;             // bit3=1;
                result = result | (uint)mask;
            }
            else if (bit3 == 1 && bit24 == 0)
            {
                int mask = 1 << 24;       //bit24=1
                result = a | (uint)mask;
                mask = ~(1 << 3);         //bit3=0
                result = result & (uint)mask;
            }
            if (bit4 == 0 && bit25 == 1)
            {
                int mask = ~(1 << 25);    //bit25=0
                if (bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0)
                {
                    result = a & (uint)mask;
                }
                else
                {
                    result = result & (uint)mask;
                }
                mask = 1 << 4;             //bit4=1       
                result = result | (uint)mask;
            }
            else if (bit4 == 1 && bit25 == 0)
            {
                int mask = 1 << 25;       //bit25=1 
                if (bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0)
                {
                    result = a | (uint)mask;
                }
                else
                {
                    result = result | (uint)mask;
                }
                mask = ~(1 << 4);         //bit4=0
                result = result & (uint)mask;
            }
            if (bit5 == 0 && bit26 == 1)
            {
                int mask = ~(1 << 26);    //bit26=0
                if ((bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0) &&
                    (bit4 == 0 && bit25 == 0 || bit4 == 0 && bit25 == 0))
                {
                    result = a & (uint)mask;
                }
                else
                {
                    result = result & (uint)mask;
                }
                mask = 1 << 5;          //bit5=1   
                result = result | (uint)mask;
            }
            else if (bit5 == 1 && bit26 == 0)
            {
                int mask = 1 << 26;         //bit26=1
                if ((bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0) &&
                   (bit4 == 0 && bit25 == 0 || bit4 == 0 && bit25 == 0))
                {
                    result = a | (uint)mask;
                }
                else
                {
                    result = result | (uint)mask;
                }
                mask = ~(1 << 5);           //bit5=0
                result = result & (uint)mask;
            }
            Console.WriteLine(result);
        }
    }
}
