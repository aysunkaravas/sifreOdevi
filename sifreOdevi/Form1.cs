using System;
using System.Text;

namespace sifreOdevi
{
    public partial class Form1 : Form
    {



        private static string BuyukHarf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string KucukHarf = "abcdefghijklmnopqrstuvwxyz";
        private static string Rakam = "0123456789";
        private static string OzElKarakter = "!@#$%^&*()_+-=[]{}|;:'\"<>,.?/";


        private object rnd;
        private bool index;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnuret_Click(object sender, EventArgs e)
        {
       
            StringBuilder karakterler = new StringBuilder();
            if (checkBoxbuyuk.Checked)
                karakterler.Append(BuyukHarf);
            if (checkBoxkucuk.Checked)
                karakterler.Append(KucukHarf);
            if (checkBoxrakam.Checked)
                karakterler.Append(Rakam);
            if (checkBoxozel.Checked)
                karakterler.Append(OzElKarakter);

            int sifreUzunlugu = int.Parse(nums�freuzunluk.Value.ToString());

            int sifreSayisi = int.Parse(nums�fresay�s�.Value.ToString());

            Random rastgele = new Random();
            for (int i = 0; i < sifreSayisi; i++)
            {
                StringBuilder sifre = new StringBuilder();
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    int index = rastgele.Next(karakterler.Length);
                    sifre.Append(karakterler[index]);
                }
                listBox1.Items.Add(sifre.ToString());



                //textBox1.Text = string.Empty;
                //Random rnd = new Random();

                //string buyukharfhavuz = "ABC�DEFG�HI�JKLMNO�PRS�TU�VYZ";
                //string kucukharfhavuz = "abc�defg�h�ijklmno�prs�tu�vyz";
                //string rakamhavuz = "1234567890";
                //string �zelhavuz = "?*/()'-+%&!@";
                //string sifre = "";


                //if (checkBoxbuyuk.Checked) { sifre += buyukharfhavuz; }
                //if (checkBoxkucuk.Checked) { sifre += kucukharfhavuz; }
                //if (checkBoxozel.Checked) { sifre += �zelhavuz; }
                //if (checkBoxrakam.Checked) { sifre += rakamhavuz; }

                //for (int i=0; i<=nums�freuzunluk.Value; i++)
                //{
                //    textBox1.Text += sifre[rnd.Next(sifre.Length)];
                //}

                //for (int i = 1; i <= nums�fresay�s�.Value; i++)
                //{
                //    string Karakter = "";
                //    for (int a = 1; a <= nums�freuzunluk.Value; a++)
                //    {
                //        int index = rnd.Next(33, 127);
                //        Karakter += Convert.ToChar(index).ToString();
                //    }
                //    textBox1.Text += i + "." + Karakter + Environment.NewLine;
                //}

                //private void lbluzunluk_Click(object sender, EventArgs e)
                //    {
                //        lbluzunluk.Text = textBox1.Text;
                //    }








            }
        }
    }
}