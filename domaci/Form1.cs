using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace domaci
{
    public partial class Form1 : Form
    {
        void refreshuj()
        {
            if (podaci.Rows.Count == 0)
            {
                topButton.Enabled = false;
                bottomButton.Enabled = false;
                leftButton.Enabled = false;
                rightButton.Enabled = false;
                deleteB.Enabled = false;
                updateB.Enabled = false;
                tbid.Text = "";
                tbNaziv.Text = "";
                tbGlgrad.Text = "";
                tbKont.Text = "";
                tbBrS.Text = "";
                tbP.Text = "";
            }
            else
            {
                tbid.Text = podaci.Rows[gde]["id"].ToString();
                tbNaziv.Text = podaci.Rows[gde]["naziv"].ToString();
                tbGlgrad.Text = podaci.Rows[gde]["glavniGrad"].ToString();
                tbKont.Text = podaci.Rows[gde]["kontinent"].ToString();
                tbP.Text = podaci.Rows[gde]["povrsina"].ToString();
                tbBrS.Text = podaci.Rows[gde]["brStan"].ToString();

                bottomButton.Enabled = (gde != podaci.Rows.Count - 1);
                rightButton.Enabled = (gde != podaci.Rows.Count - 1);
                topButton.Enabled = (gde != 0);
                leftButton.Enabled = (gde != 0);
            }

        }
        string cs = "Data source = DESKTOP-U3IAE97; Initial catalog = Drzava; Integrated security = true";
        int gde = 0;
        DataTable podaci = new DataTable();
        SqlConnection veza;
        string naz, kont, glgrad, brst, pov;

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (gde + 1 <= podaci.Rows.Count)
            {
                gde++;
                refreshuj();
            }
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            SqlCommand naredba = new SqlCommand(String.Format($"delete from drzava where id={tbid.Text}"), veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            podaci.Clear();
            adapter = new SqlDataAdapter("select * from drzava", veza);
            adapter.Fill(podaci);
            gde = 0;
            refreshuj();
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            naz = tbNaziv.Text;
            kont = tbKont.Text;
            glgrad = tbGlgrad.Text;
            pov = tbP.Text;
            brst = tbBrS.Text;
            if (naz == "" && kont == "" && glgrad == "" && pov == "" && brst == "")
                MessageBox.Show("Unesite bar jedan podatak za izmenu");
            veza.Open();
            SqlCommand naredba = new SqlCommand($"update drzava set naziv = '{naz}', kontinent = '{kont}', glavniGrad = '{glgrad}', povrsina = '{pov}', brStan = '{brst}' where id = {tbid.Text}", veza);
            naredba.ExecuteNonQuery();
            veza.Close();
            podaci.Clear();
            adapter = new SqlDataAdapter("select * from drzava", veza);
            adapter.Fill(podaci);
            refreshuj();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tbNaziv.Text = "";
            tbKont.Text = "";
            tbGlgrad.Text = "";
            tbBrS.Text = "";
            tbP.Text = "";
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (gde - 1 >= 0)
            {
                gde--;
                refreshuj();
            }
        }

        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veza = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from firma", veza);
            adapter.Fill(podaci);
            tbid.Enabled = false;
            refreshuj();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
