using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _7__Kelime_Ögren
{
    public partial class FrmUygulama : Form
    {
        public FrmUygulama()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Program Files (x86)\Default Company Name\Setup1\dbSozluk.accdb");
        Random rast = new Random();
        int süre = 90;
        int dogrusayisi = 0;
        int yanlissayisi = 0;
        int toplam;
        // uı ekranını windows screen'de hareket ettirme
        Point İlkkonum; 
        bool durum = false;

        class hafızadakisayilar
        {
            public int s1;
            public int s2;
            public int s3;
            public int s4;
            public int s5;
            public int s6;
            public int s7;
            public int s8;
            public int s9;
        }
        hafızadakisayilar rst = new hafızadakisayilar();        

        void getir()
        {            
            // btnrastgelekelime1
            rst.s1 = rast.Next(1, 2490);            
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s1);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                BtnRastgeleKelime1.Text = dr[1].ToString();                
            }
            baglanti.Close();

            //btnrastgelekelime2
            rst.s2 = rast.Next(1, 2490);
            baglanti.Open();            
            OleDbCommand komut2 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", rst.s2);
            OleDbDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                BtnRastgeleKelime2.Text = dr2[1].ToString();
            }
            baglanti.Close();

            //btnrastgelekelime3
            rst.s3 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", rst.s3);
            OleDbDataReader dr3 = komut3.ExecuteReader();
            if (dr3.Read())
            {
                BtnRastgeleKelime3.Text = dr3[1].ToString();                
            }
            baglanti.Close();

            //btnrastgelekelime4
            rst.s4 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", rst.s4);
            OleDbDataReader dr4 = komut4.ExecuteReader();
            if (dr4.Read())
            {
                BtnRastgeleKelime4.Text = dr4[1].ToString();
            }
            baglanti.Close();

            //btnrastgelekelime6
            rst.s6 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut6 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut6.Parameters.AddWithValue("@p1", rst.s6);
            OleDbDataReader dr6 = komut6.ExecuteReader();
            if (dr6.Read())
            {
                BtnRastgeleKelime6.Text = dr6[1].ToString();
            }
            baglanti.Close();

            //btnrastgelekelime7
            rst.s7 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut7 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut7.Parameters.AddWithValue("@p1", rst.s7);
            OleDbDataReader dr7 = komut7.ExecuteReader();
            if (dr7.Read())
            {
                BtnRastgeleKelime7.Text = dr7[1].ToString();
            }
            baglanti.Close();

            //btnrastgelekelime8
            rst.s8 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut8 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut8.Parameters.AddWithValue("@p1", rst.s8);
            OleDbDataReader dr8 = komut8.ExecuteReader();
            if (dr8.Read())
            {
                BtnRastgeleKelime8.Text = dr8[1].ToString();
            }
            baglanti.Close();

            //btnrastgelekelime9
            rst.s9 = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut9 = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut9.Parameters.AddWithValue("@p1", rst.s9);
            OleDbDataReader dr9 = komut9.ExecuteReader();
            if (dr9.Read())
            {
                BtnRastgeleKelime9.Text = dr9[1].ToString();
            }
            baglanti.Close();
        }
        private void Allbutons()
        {
            if (BtnRastgeleKelime1.BackColor == Color.Orange)
                BtnRastgeleKelime1.BackColor = Color.White;
            if (BtnRastgeleKelime2.BackColor == Color.Orange)
                BtnRastgeleKelime2.BackColor = Color.White;
            if (BtnRastgeleKelime3.BackColor == Color.Orange)
                BtnRastgeleKelime3.BackColor = Color.White;
            if (BtnRastgeleKelime4.BackColor == Color.Orange)
                BtnRastgeleKelime4.BackColor = Color.White;
            if (BtnRastgeleKelime6.BackColor == Color.Orange)
                BtnRastgeleKelime6.BackColor = Color.White;
            if (BtnRastgeleKelime7.BackColor == Color.Orange)
                BtnRastgeleKelime7.BackColor = Color.White;
            if (BtnRastgeleKelime8.BackColor == Color.Orange)
                BtnRastgeleKelime8.BackColor = Color.White;
            if (BtnRastgeleKelime9.BackColor == Color.Orange)
                BtnRastgeleKelime9.BackColor = Color.White;
        }
        private void ShowButtons(Button sbutton)
        {
            if (sbutton.BackColor == Color.White)
            {
                Allbutons();
                sbutton.BackColor = Color.Orange;
            }
            else
                sbutton.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            LblSüre.Text = süre.ToString();
            if(süre == 0 || toplam == 8)
            {                                                   
                TxtTürkçeCevap.Enabled = false;                
                timer1.Stop();
                BtnBaşla.Enabled = true;
                MessageBox.Show("Tebrikler...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRastgeleKelime1.BackColor = Color.White;
                BtnRastgeleKelime2.BackColor = Color.White;
                BtnRastgeleKelime3.BackColor = Color.White;
                BtnRastgeleKelime4.BackColor = Color.White;
                BtnRastgeleKelime6.BackColor = Color.White;
                BtnRastgeleKelime7.BackColor = Color.White;
                BtnRastgeleKelime8.BackColor = Color.White;
                BtnRastgeleKelime9.BackColor = Color.White;

                LblDogruSayisi.Text = "0";
                dogrusayisi = 0;
                LblYanlisSayisi.Text = "0";
                yanlissayisi = 0;
                LblToplam.Text = "0";
                toplam = 0;
                süre = 90;
                LblSüre.Text = süre.ToString();

                BtnRastgeleKelime1.Enabled = true;
                BtnRastgeleKelime2.Enabled = true;
                BtnRastgeleKelime3.Enabled = true;
                BtnRastgeleKelime4.Enabled = true;
                BtnRastgeleKelime6.Enabled = true;
                BtnRastgeleKelime7.Enabled = true;
                BtnRastgeleKelime8.Enabled = true;
                BtnRastgeleKelime9.Enabled = true;
            }
        }

        private void BtnCevapla_Click(object sender, EventArgs e)
        {
            

            if (BtnRastgeleKelime1.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime1.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime1.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime1.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime1.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";                    
                }
            }
           if(BtnRastgeleKelime2.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime2.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime2.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime2.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime2.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime3.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime3.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime3.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime3.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime3.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime4.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime4.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime4.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime4.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime4.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime6.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime6.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime6.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime6.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime6.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime7.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime7.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime7.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime7.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime7.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime8.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime8.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime8.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime8.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime8.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
            if (BtnRastgeleKelime9.BackColor == Color.Orange)
            {
                if (TxtTürkçeCevap.Text == LblCevap.Text)
                {
                    BtnRastgeleKelime9.BackColor = Color.Green;
                    dogrusayisi++;
                    LblDogruSayisi.Text = dogrusayisi.ToString();
                    BtnRastgeleKelime9.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
                else
                {
                    BtnRastgeleKelime9.BackColor = Color.Red;
                    yanlissayisi++;
                    LblYanlisSayisi.Text = yanlissayisi.ToString();
                    BtnRastgeleKelime9.Enabled = false;
                    toplam++;
                    LblToplam.Text = toplam.ToString();
                    TxtTürkçeCevap.Text = "";
                }
            }
        }

        private void BtnBaşla_Click(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
            BtnBaşla.Enabled = false;            
            TxtTürkçeCevap.Enabled = true;
        }
         
        private void BtnRastgeleKelime1_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime1);        
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s1);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {                
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime2_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime2);
            baglanti.Open();            
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s2);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }
 
        private void BtnRastgeleKelime3_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime3);                     
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s3);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime4_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime4);                     
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s4);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime6_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime6);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s6);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime7_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime7);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s7);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime8_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime8);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s8);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void BtnRastgeleKelime9_Click(object sender, EventArgs e)
        {
            ShowButtons(BtnRastgeleKelime9);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", rst.s9);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse a tıklandığı anda. Burada sol yada sağ tıklanması farketmeyecektir.
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location; /* İlk konum olarak fareye tam basıldığında e parametresinin Location özelliğini
                                    * kullanarak konum aldık. X ve Y koordinatlarını almış olduk.*/
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Mouse'u hareket ettirdiğimizde çalışacak kodlar.
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Mouse'u bıraktığımızda çalışacak kodlar.
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.
        }
       
    }
}
