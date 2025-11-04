using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_di_hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] Listacolori = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Purple };
        int i = 0;
        int length; 

        List<Panel> Primalista = new List<Panel>();
        List<Panel> Secondalista = new List<Panel>();
        List<Panel> Terzalista = new List<Panel>();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Resetgame();

            int nDischi = (int)sel_Rings.Value;

            //vado a fare si che ci sia sempre il pio piccolo in cima
            //tolgo al valore massimo il valore dei dischi cha non ci sono nella piramide
            length = 140 - (18 * (7-nDischi));  

            for (int i = 0; i < nDischi; i++)
            {
                CreatePanel(Pnl_Base1);
            }
            
        }

        private void CreatePanel(Panel PannelloBase)
        {
            Panel DiscoNuovo = new Panel();

            DiscoNuovo.Height = 15;
            DiscoNuovo.Size = new Size(length, 15);

            DiscoNuovo.BackColor = Listacolori[i];
            DiscoNuovo.Location = new Point(CalculateX(DiscoNuovo, PannelloBase ), CalculateY(PannelloBase, Primalista));
            
            length -= 18;
            i = i < 6 ? i+1 : 0;

            //aggiungo il pannello istanziato nel form
            Controls.Add(DiscoNuovo);
            DiscoNuovo.BringToFront();
            //gli assegnam oun nome e li mettiamo in una lista
            DiscoNuovo.Name = $"pnl_{i+1}";
            Primalista.Add(DiscoNuovo);
        }

        private int CalculateX(Panel MovedPanel, Panel BasePanel)
        {
            return BasePanel.Location.X + ((BasePanel.Width - MovedPanel.Width) / 2);
        }

        private int CalculateY( Panel BasePanel, List<Panel> Lista)
        {
            int y = BasePanel.Location.Y;
            y -= 15;
            foreach (var element in Lista)
            {
                y -= 15;
            }
            return y;
        }

        private void Resetgame()
        {
            foreach (var element in Primalista)
            {
                element.Dispose();
            }
            
            foreach (var element in Secondalista)
            {
                element.Dispose();
            }

            foreach (var element in Terzalista)
            {
                element.Dispose();
            }

            Primalista.Clear();
            Primalista.Clear();
            Primalista.Clear();
            i = 0;
        }
    }
}
