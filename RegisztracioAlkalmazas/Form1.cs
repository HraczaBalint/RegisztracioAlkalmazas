using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        private string ujHobbi;
        private string nev;
        private string szuletesiDatum;
        private string nem;
        private string hobbi;
        private List<string> felhasznalo = new List<string>();
        private List<string> osszHobbi = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNev.Focus();
            listBoxHobbik.SelectedIndex = 0;
            radioButtonNemF.Checked = true;
            dateTimePickerSzulDat.MaxDate = DateTime.Today;
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            ujHobbi = textBoxUjHobbi.Text.Trim();

            if (String.IsNullOrEmpty(ujHobbi))
            {
                MessageBox.Show("Adjon meg egy új hobbit!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUjHobbi.Clear();
                textBoxUjHobbi.Focus();
            }
            else if (listBoxHobbik.Items.Contains(ujHobbi))
            {
                MessageBox.Show("Ez az elem már létezik!", "Hozzáadás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUjHobbi.Clear();
                textBoxUjHobbi.Focus();
            }
            else
            {
                listBoxHobbik.Items.Add(ujHobbi);
                listBoxHobbik.SelectedItem = ujHobbi;
                textBoxUjHobbi.Clear();
                textBoxUjHobbi.Focus();
            }
            
            
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            szuletesiDatum = dateTimePickerSzulDat.Value.ToShortDateString();

            if (radioButtonNemF.Checked)
            {
                nem = "ferfi";
            }
            else if (radioButtonNemN.Checked)
            {
                nem = "no";
            }

            hobbi = listBoxHobbik.SelectedItem.ToString();

            nev = textBoxNev.Text.Trim();
            if (string.IsNullOrEmpty(nev))
            {
                MessageBox.Show("Adjon meg egy nevet!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNev.Clear();
                textBoxNev.Focus();
            }
            else
            {
                felhasznalo.Add(String.Format("{0};{1};{2};{3};", nev, szuletesiDatum, nem, hobbi));
                foreach (var item in listBoxHobbik.Items)
                {
                    osszHobbi.Add(item.ToString());
                }
                DialogResult result = saveFileDialogMentes.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }

                using (StreamWriter sw = new StreamWriter(saveFileDialogMentes.FileName))
                {
                    sw.Write(felhasznalo[0]);
                    sw.Write(listBoxHobbik.Items[0]);
                    for (int i = 1; i < listBoxHobbik.Items.Count; i++)
                    {
                        sw.Write("," + listBoxHobbik.Items[i]);
                    }
                }
                MessageBox.Show("Mentve!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                felhasznalo.Clear();
                osszHobbi.Clear();
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogBetoltes.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            using (StreamReader sr = new StreamReader(openFileDialogBetoltes.FileName))
            {
                listBoxHobbik.Items.Clear();

                string[] sor = sr.ReadLine().Split(';');
                textBoxNev.Text = sor[0];
                dateTimePickerSzulDat.Value = Convert.ToDateTime(sor[1]);
                if (sor[2] == "ferfi")
                {
                    radioButtonNemF.Checked = true;
                }
                else if (sor[2] == "no")
                {
                    radioButtonNemN.Checked = true;
                }
                string[] hobbik = sor[4].Split(',');
                foreach (var item in hobbik)
                {
                    listBoxHobbik.Items.Add(item);
                }
                listBoxHobbik.SelectedItem = sor[3];
            }
        }
    }
}
