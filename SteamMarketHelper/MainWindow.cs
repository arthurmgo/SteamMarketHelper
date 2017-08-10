using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMarketHelper {

    public partial class MainWindow : Form {

        HistoricoVenda historico;

        public MainWindow() {
            InitializeComponent();
            historico = new HistoricoVenda();
        }

        private void AdicionarItem(string url) {
            // adicionar URL no arquivo de urls
            string html = Market.DownloadPage(url);
            historico.SetVendasFromHtml(html);
            int itemId = Market.ItemIdFromHtml(html);
            // adicionar o id do item no arquivo de IDs
            // criar uma nova linha na tabela contendo as informações:
            string nome_item = Market.NameFromUrl(url);
            double preco_medio = historico.MedianPrice();
            double enc_mais_alta = (double.Parse(BuyOrder.Unpack(Market.BuyOrderForItem(itemId)).highest_buy_order))/100;
            double preco_ultima_venda = historico.PriceOfLastSale();
            DateTime data_ultima_venda = historico.DateOfLastSale();
            dataGridViewItems.Rows.Add(url, preco_medio, enc_mais_alta, preco_ultima_venda, data_ultima_venda.ToString("dd/MM/yyyy"));
            //dataGridViewItems[0, dataGridViewItems.Rows.Count - 1].Value = url;
            historico.Free();
        }

        private void buttonNovoItem_Click(object sender, EventArgs e) {
            InputURL janelaURL = new InputURL();
            janelaURL.Visible = true;
            if (janelaURL.pronto) {
                string url = janelaURL.url;
                janelaURL.Dispose();
                AdicionarItem(url);
            } else
                janelaURL.Dispose();
        }

        private void buttonExcluirItem_Click(object sender, EventArgs e) {

        }

        private void buttonRefresh_Click(object sender, EventArgs e) {

        }

        private void buttonOportunidade_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewItems.Rows.Clear();
            dataGridViewItems.Dispose();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
            {
                System.Diagnostics.Process.Start(dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
            }
        }
    }

}
