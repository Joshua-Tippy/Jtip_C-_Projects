using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    class Network
    {
        private int[] hosts;
        private int subnet;
        private int network;

        public int[] Hosts
        {
            get
            {
                return;
            }
            set
            {
                hosts = value;
            }
        }

        public int Networkranges
        {
            get
            {
                return network;
            }
            set
            {
                network = value;
            }
        }

        public int Subnet
        {
            get
            {
                return subnet;
            }
            set
            {
                subnet = value;
            }
        }

        public Network(int[] h, int s = 0, int n = 0)
        {
            hosts = h;
            network = n;
            subnet = s;
        }
    }
}
