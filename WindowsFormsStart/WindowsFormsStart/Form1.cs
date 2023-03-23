using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSzam1.Text.Length==0 || textBoxSzam2.Text.Length==0)
                {
                    throw new ArgumentException("Egyik mező sem lehet üres!");
                }
                var szam1 = Convert.ToDouble(textBoxSzam1.Text);
                var szam2 = Convert.ToDouble(textBoxSzam2.Text);
                var eredmeny = szam1 * szam2;
                labelEredmeny.Text = eredmeny.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot kell megadni!","Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
