using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SteamMarketHelper {

    public static class Market {

        public static string NameFromUrl(string url) { // retorna o nome do item a partir da url dele
            string decoded = Uri.UnescapeDataString(url);
            int ix = decoded.IndexOf("listings");
            if (ix == -1)
                return "";
            for (ix+=9; decoded.ElementAt(ix)!='/'; ix++);
            return decoded.Substring(ix + 1);
        }

        public static int ItemIdFromUrl(string url) { // retorna o id do item a partir da url dele
            return ItemIdFromHtml(DownloadPage(url));
        }

        public static int ItemIdFromHtml(string htmlpage) { // retorna o id do item a partir do html
            int byte_offset = htmlpage.IndexOf("Market_LoadOrderSpread( ") + 24;
            String idprov = "";
            while (htmlpage.ElementAt(byte_offset) != ' ') {
                idprov += htmlpage.ElementAt(byte_offset);
                byte_offset++;
            }

            return int.Parse(idprov);
        }
        
        public static string BuyOrderForItem(int itemId) { // retorna o json do item
            return DownloadPage("http://steamcommunity.com/market/itemordershistogram?countryBR&language=portuguese&currency=7&item_nameid=" + itemId + "&two_factor=0");
        }

        public static string DownloadPage(string url) { // baixa uma pagina
            using (WebClient wc = new WebClient()) {
                return wc.DownloadString(url);
            }
        }

    }

}
