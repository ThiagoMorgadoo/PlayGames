using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayGames
{
    public partial class Frm_SuperNintendo : Form
    {
        public Frm_SuperNintendo()
        {
            InitializeComponent();
        }

        private void ListaRoms_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            string[] listaroms = Directory.GetFiles(@"C:\Projeto\PlayGames\PlayGames\RomsSupernitendo");
            foreach (string Ficheiro in listaroms)
            {
                ListaRoms.Items.Add(Ficheiro);
            }
            lbl_qtd.Text = ListaRoms.Items.Count.ToString();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_qtd_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
