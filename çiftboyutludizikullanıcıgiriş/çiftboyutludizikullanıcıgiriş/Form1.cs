using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çiftboyutludizikullanıcıgiriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] kullanıcı = new string[2,3];
        
        
        
        int i = 0, j = 0;

        

        private void girisbtn_Click(object sender, EventArgs e)
        {
            
          

            if (kullanıcı[0, 0] == idtxt.Text && kullanıcı[0, 1] == adtxt.Text && kullanıcı[0, 2] == sifretxt.Text)
            {
                bilgitxt.Text = "giriş başarılı";
            }
            else if (kullanıcı[1, 0] == idtxt.Text && kullanıcı[1, 1] == adtxt.Text && kullanıcı[1, 2] == sifretxt.Text)
            {
                bilgitxt.Text = "giriş başarılı";
            }
            else
            {
                bilgitxt.Text = "kullanıcı bulunamadı, kaydolmak için kaydol butonuna basınız!";
                kaydolbtn.Visible= true;
            }





        }

        private void kaydolbtn_Click(object sender, EventArgs e)
        {
            kaydolbtn.Visible= false;
            if (i < 2 )
            {
                kullanıcı[i, j] = idtxt.Text;
                j++;
                kullanıcı[i, j] = adtxt.Text;
                j++;
                kullanıcı[i, j] = sifretxt.Text;
                i++;
                
                j = 0;
                bilgitxt.Text = "kayıt başarılı";
            }
            else
            {
                bilgitxt.Text = "çok fazla kullanıcı kaydolamaz";
            }

        }
    }
}
