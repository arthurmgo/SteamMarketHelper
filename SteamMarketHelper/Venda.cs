using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketHelper {

    public class Venda {

        public DateTime data_venda;
        public double preco_venda;
        public int qtd_vendidos;

        public Venda(DateTime data_venda, double preco_venda, int qtd_vendidos) {
            this.data_venda = data_venda;
            this.preco_venda = preco_venda;
            this.qtd_vendidos = qtd_vendidos;
        }

        public override string ToString() {
            return (data_venda.ToString()+ "|" +preco_venda+ "|"  +qtd_vendidos+ "\n");
        }

    }
}
