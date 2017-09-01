using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SteamMarketHelper {

    class Arquivo{

        FileStream file;

        public Arquivo(string diret, int mode) {
            switch(mode) {
                case 1:
                    file = File.Open(diret, FileMode.Open, FileAccess.Read);
                    break;
                case 2:
                    file = File.Open(diret, FileMode.Open, FileAccess.Write);
                    break;
                case 3:
                    file = File.Open(diret, FileMode.Open, FileAccess.ReadWrite);
                    break;
                default:
                    file = File.Open(diret, FileMode.Append, FileAccess.Write);
                    break;
            }
        }


    }

}
