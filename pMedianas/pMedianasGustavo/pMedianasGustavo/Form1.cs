using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pMedianasGustavo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            ProblemaPMedianas MeuProblema = new ProblemaPMedianas();
            MeuProblema.LerInstancia(@"D:\Dropbox\UFPR\PPGOLD\Modelagem na Cadeia de Suprimentos\pMedianas\Ex1_0.txt");
            MeuProblema.CalcularDistanciasEntreItens();
            MeuProblema.NumeroMedianas = int.Parse(txtNumeroMedianas.Text);
            MeuProblema.InicializaMedianas();
            MeuProblema.CriarCoresAleatoriasParaMedianas();
            MeuProblema.CriarResolverModeloExato();
            MeuProblema.CalcularDistanciaTotal();
            this.Text = MeuProblema.DistanciaTotal.ToString();
            picDesenhoResultado.Image = null;
            picDesenhoResultado.Image = MeuProblema.Desenhar();
        }
    }
}
