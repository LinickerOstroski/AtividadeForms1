using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora_de_Juros_de_Financiamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double taxaAnual = double.Parse(txtTaxa.Text);
            double valorPrincipal = double.Parse(txtPrincipal.Text);
            int numeroParcelas = int.Parse(txtParcelas.Text);

            double taxaMensal = (taxaAnual / 100) / 12;
            double valorDaParcela = valorPrincipal * (taxaMensal / (1 - Math.Pow(1 + taxaMensal, -numeroParcelas)));

            double totalDeJuros = (valorDaParcela * numeroParcelas) - valorPrincipal;
            double totalPago = valorPrincipal + totalDeJuros;

            lblResultado.Text = "Valor da parcela:" + valorDaParcela.ToString("N2");
            lblResultado1.Text = "Total em Juros:" + totalDeJuros.ToString("N2");
            lblResultado2.Text = "Total Pago:" + totalPago.ToString("N2");
        }
    }
}