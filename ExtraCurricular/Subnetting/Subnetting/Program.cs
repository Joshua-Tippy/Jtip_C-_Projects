using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int subnet;
            int network;
            int x = 0, y = 1;

            WriteLine("Enter your network: ");
            network = RemoveDecimals(Convert.ToString(ReadLine()));

            WriteLine("Enter your network subnet: ");
            subnet = RemoveDecimals(Convert.ToString(ReadLine()));

            
            Write("How many networks would you like?  ");
            x = Convert.ToInt32(ReadLine());
            int[] networks = new int[x];
            
            foreach(int value in networks)
            {
                Write("How Many hosts would you like on network {0}: ", y);
                networks[x] = Convert.ToInt32(ReadLine());
                ++x;
                ++y;
            }
            Network N1 = new Network(networks, subnet, network);

            x = 0;
            y = 1;
            foreach (int value in networks)
            {
                WriteLine("Hosts on Network {0}: {1}", y, networks[x]);
                ++x;
                ++y;
            }
        }

        static int RemoveDecimals(string str)
        {
            int num1 = str.IndexOf('.');
            str = str.Remove(num1, 1);
            int num2 = str.IndexOf('.');
            str = str.Remove(num2, 1);
            int num3 = str.IndexOf('.');
            str = str.Remove(num3, 1);
            int num = Convert.ToInt32(str);
            return num;
        }
    }
}
