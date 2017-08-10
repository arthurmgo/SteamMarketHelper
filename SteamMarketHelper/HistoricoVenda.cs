using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketHelper {
    public class HistoricoVenda {

        private List<Venda> vendas;
        Dictionary<string, int> months = new Dictionary<string, int>() {
                { "Jan", 1 },
                { "Feb", 2 },
                { "Mar", 3 },
                { "Apr", 4 },
                { "May", 5 },
                { "Jun", 6 },
                { "Jul", 7 },
                { "Aug", 8 },
                { "Sep", 9 },
                { "Oct", 10 },
                { "Nov", 11 },
                { "Dec", 12 },
        };

        public HistoricoVenda() {
            vendas = new List<Venda>();
        }

        public void Free() {
            vendas.Clear();
        }

        public double PriceOfLastSale() {
            return vendas.ElementAt(0).preco_venda;
        }

        public DateTime DateOfLastSale() {
            return vendas.ElementAt(0).data_venda;
        }

        public double MedianPrice() {
            double soma = 0;
            foreach (Venda sale in vendas) {
                soma += sale.preco_venda;
            }
            return soma / (vendas.Count);
        }

        public void SetVendasFromHtml(string html) {
            int i = html.LastIndexOf("];")-1;
            if (html.ElementAt(i) == '[') // mudar a condição, provavelmente procurar por algo similar a "this item doesn't have a history yet"
                return;

            string info_venda = "";
            DateTime data_atual = DateTime.Today;

            DateTime data_venda;
            double preco_venda;
            int quantidade_vendidos;
            
            while (true) {
                if (html.ElementAt(i) == '=')
                    break;

                while (html.ElementAt(i) != '[') {
                    info_venda += html.ElementAt(i);
                    i--;
                }
                i-=2;
                info_venda += "[";
                info_venda = ReverseString(info_venda);

                data_venda = ExtractDateFromString(info_venda);
                if (data_venda.CompareTo(data_atual.AddDays(-8)) != 1) // se a data da venda for mais de 7 dias atrás parar de procurar por vendas mais antigas
                    break;
                preco_venda = ExtractPriceFromString(info_venda);
                quantidade_vendidos = ExtractSoldAmountFromString(info_venda);
                vendas.Add(new Venda(data_venda, preco_venda, quantidade_vendidos));
                info_venda = "";
            }
            
        }

        private string ReverseString(string toreverse) {
            char[] array = toreverse.ToCharArray();
            Array.Reverse(array);
            return String.Join("", array);
        }

        public DateTime ExtractDateFromString(string info) {
            int dia = int.Parse(info.ElementAt(6).ToString() + info.ElementAt(7));
            int mes;
            months.TryGetValue(info.ElementAt(2).ToString() + info.ElementAt(3) + info.ElementAt(4), out mes);
            int ano = int.Parse(info.ElementAt(9).ToString() + info.ElementAt(10) + info.ElementAt(11) + info.ElementAt(12));
            return new DateTime(ano, mes, dia);
        }

        public double ExtractPriceFromString(string info) {
            string preco_prov = "";
            for (int i = 22; info.ElementAt(i) != ','; i++)
                preco_prov += info.ElementAt(i);
                
            return double.Parse(preco_prov, System.Globalization.CultureInfo.InvariantCulture);
        }

        public int ExtractSoldAmountFromString(string info) {
            string qtd_prov = "";
            for (int i = info.Length-3; info.ElementAt(i) != '"'; i--)
                qtd_prov += info.ElementAt(i);
            return int.Parse(ReverseString(qtd_prov));
        }

    }
}
