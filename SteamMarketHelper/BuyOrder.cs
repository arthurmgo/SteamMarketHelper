using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SteamMarketHelper {

    public class BuyOrder {
        public int success { get; set; }
        public string sell_order_table { get; set; }
        public string sell_order_summary { get; set; }
        public string buy_order_table { get; set; }
        public string buy_order_summary { get; set; }
        public string highest_buy_order { get; set; }
        public string lowest_sell_order { get; set; }
        public List<List<object>> buy_order_graph { get; set; }
        public List<List<object>> sell_order_graph { get; set; }
        public int graph_max_y { get; set; }
        public double graph_min_x { get; set; }
        public double graph_max_x { get; set; }
        public string price_prefix { get; set; }
        public string price_suffix { get; set; }

        public static BuyOrder Unpack(string jsoncode) { // tira as informações do json pra classe BuyOrder
            return JsonConvert.DeserializeObject<BuyOrder>(jsoncode);
        }

    }
}
