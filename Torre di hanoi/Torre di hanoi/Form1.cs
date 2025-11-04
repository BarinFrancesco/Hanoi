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
            YIniziale = Pnl_Base.Location.Y - 15;
        }

        Color[] Listacolori = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Purple };
        int i = 0;
        int length = 130;
        int XIniziale = 50;
        int YIniziale;

        List<Panel> Primalista = new List<Panel>();
        List<Panel> Secondalista = new List<Panel>();
        List<Panel> Terzalista = new List<Panel>();

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int nDischi = (int)sel_Rings.Value;

            for(int i = 0; i < nDischi; i++)
            {
                CalculateX();
                CreatePanel(XIniziale, YIniziale);
                YIniziale -= 15;
            }
            
        }

        private void CreatePanel(int x, int y)
        {
            Panel DiscoNuovo = new Panel();
            DiscoNuovo.Height = 15;
            DiscoNuovo.Size = new Size(length, 15);
            DiscoNuovo.BackColor = Listacolori[i];
            DiscoNuovo.Location = new Point(x, y);
            
            length -= 15;
            i = i < 6 ? i+1 : 0;
            //aggiungo il pannello istanziato nel form
            Controls.Add(DiscoNuovo);
            DiscoNuovo.BringToFront();
            DiscoNuovo.Name = $"pnl_{i+1}";
            Primalista.Add(DiscoNuovo);
        }

        private void CalculateX()
        {
            XIniziale = Pnl_Base.Location.X + ((Pnl_Base.Width - length) / 2);
        }
    }
}
