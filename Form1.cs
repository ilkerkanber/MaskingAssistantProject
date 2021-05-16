using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskelemeAsistanıProjesi
{
    public partial class Form1 : Form
    {
        public int hr250, hr500, hr1000, hr2000, hr4000, hr6000, hr8000;
        public int hl250, hl500, hl1000, hl2000, hl4000, hl6000, hl8000;
        public int kr250, kr500, kr1000, kr2000, kr4000;
        public int kl250, kl500, kl1000, kl2000, kl4000;
       
        public bool sol250 = false, sol500 = false, sol1000 = false, sol2000 = false, sol4000 = false;
        public bool sag250 = false, sag500 = false, sag1000 = false, sag2000 = false, sag4000 = false;

        private void HavaKontrolTimer_Tick(object sender, EventArgs e)
        {
            VeriAl();
            timer250.Start();
            HavaControlTimer.Stop();
        }
        private void timer250_Tick(object sender, EventArgs e)
        {
            Sinyal250();
        }
        private void timer500_Tick(object sender, EventArgs e)
        {
            Sinyal500();
        }

        private void timer1000_Tick(object sender, EventArgs e)
        {
            Sinyal1000();
        }

        private void hsag1_TextChanged(object sender, EventArgs e)
        {
            if (hsag1.Text != "-") { hsag1.BackColor = Color.Green; hsag1.ForeColor = Color.White; }
            else { hsag1.BackColor = Color.White; hsag1.ForeColor = Color.Black; }
        }

        private void hsag2_TextChanged(object sender, EventArgs e)
        {
            if (hsag2.Text != "-") { hsag2.BackColor = Color.Green; hsag2.ForeColor = Color.White; }
            else { hsag2.BackColor = Color.White; hsag2.ForeColor = Color.Black; }

        }

        private void hsag3_TextChanged(object sender, EventArgs e)
        {
            if (hsag3.Text != "-") { hsag3.BackColor = Color.Green; hsag3.ForeColor = Color.White; }
            else { hsag3.BackColor = Color.White; hsag3.ForeColor = Color.Black; }

        }

        private void hsag4_TextChanged(object sender, EventArgs e)
        {
            if (hsag4.Text != "-") { hsag4.BackColor = Color.Green; hsag4.ForeColor = Color.White; }
            else { hsag4.BackColor = Color.White; hsag4.ForeColor = Color.Black; }
        }

        private void hsag5_TextChanged(object sender, EventArgs e)
        {
            if (hsag5.Text != "-") { hsag5.BackColor = Color.Green; hsag5.ForeColor = Color.White; }
            else { hsag5.BackColor = Color.White; hsag5.ForeColor = Color.Black; }
        }

        private void hsag6_TextChanged(object sender, EventArgs e)
        {
            if (hsag6.Text != "-") { hsag6.BackColor = Color.Green; hsag6.ForeColor = Color.White; }
            else { hsag6.BackColor = Color.White; hsag6.ForeColor = Color.Black; }

        }

        private void hsag7_TextChanged(object sender, EventArgs e)
        {
            if (hsag7.Text != "-") { hsag7.BackColor = Color.Green; hsag7.ForeColor = Color.White; }
            else { hsag7.BackColor = Color.White; hsag7.ForeColor = Color.Black; }

        }

        private void ksag1_TextChanged(object sender, EventArgs e)
        {
            if (ksag1.Text != "-") { ksag1.BackColor = Color.Green; ksag1.ForeColor = Color.White; }
            else { ksag1.BackColor = Color.White; ksag1.ForeColor = Color.Black; }

        }

        private void ksag2_TextChanged(object sender, EventArgs e)
        {
            if (ksag2.Text != "-") { ksag2.BackColor = Color.Green; ksag2.ForeColor = Color.White; }
            else { ksag2.BackColor = Color.White; ksag2.ForeColor = Color.Black; }

        }

        private void ksag3_TextChanged(object sender, EventArgs e)
        {
            if (ksag3.Text != "-") { ksag3.BackColor = Color.Green; ksag3.ForeColor = Color.White; }
            else { ksag3.BackColor = Color.White; ksag3.ForeColor = Color.Black; }

        }

        private void ksag4_TextChanged(object sender, EventArgs e)
        {
            if (ksag4.Text != "-") { ksag4.BackColor = Color.Green; ksag4.ForeColor = Color.White; }
            else { ksag4.BackColor = Color.White; ksag4.ForeColor = Color.Black; }

        }

        private void ksag5_TextChanged(object sender, EventArgs e)
        {
            if (ksag5.Text != "-") { ksag5.BackColor = Color.Green; ksag5.ForeColor = Color.White; }
            else { ksag5.BackColor = Color.White; ksag5.ForeColor = Color.Black; }

        }

        private void hsol1_TextChanged(object sender, EventArgs e)
        {
            if (hsol1.Text != "-") { hsol1.BackColor = Color.Green; hsol1.ForeColor = Color.White; }
            else { hsol1.BackColor = Color.White; hsol1.ForeColor = Color.Black; }

        }

        private void hsol2_TextChanged(object sender, EventArgs e)
        {
            if (hsol2.Text != "-") { hsol2.BackColor = Color.Green; hsol2.ForeColor = Color.White; }
            else { hsol2.BackColor = Color.White; hsol2.ForeColor = Color.Black; }

        }

        private void hsol3_TextChanged(object sender, EventArgs e)
        {
            if (hsol3.Text != "-") { hsol3.BackColor = Color.Green; hsol3.ForeColor = Color.White; }
            else { hsol3.BackColor = Color.White; hsol3.ForeColor = Color.Black; }

        }

        private void hsol4_TextChanged(object sender, EventArgs e)
        {
            if (hsol4.Text != "-") { hsol4.BackColor = Color.Green; hsol4.ForeColor = Color.White; }
            else { hsol4.BackColor = Color.White; hsol4.ForeColor = Color.Black; }

        }

        private void hsol5_TextChanged(object sender, EventArgs e)
        {
            if (hsol5.Text != "-") { hsol5.BackColor = Color.Green; hsol5.ForeColor = Color.White; }
            else { hsol5.BackColor = Color.White; hsol5.ForeColor = Color.Black; }

        }

        private void hsol6_TextChanged(object sender, EventArgs e)
        {
            if (hsol6.Text != "-") { hsol6.BackColor = Color.Green; hsol6.ForeColor = Color.White; }
            else { hsol6.BackColor = Color.White; hsol6.ForeColor = Color.Black; }

        }

        private void hsol7_TextChanged(object sender, EventArgs e)
        {
            if (hsol7.Text != "-") { hsol7.BackColor = Color.Green; hsol7.ForeColor = Color.White; }
            else { hsol7.BackColor = Color.White; hsol7.ForeColor = Color.Black; }

        }

        private void ksol1_TextChanged(object sender, EventArgs e)
        {
            if (ksol1.Text != "-") { ksol1.BackColor = Color.Green; ksol1.ForeColor = Color.White; }
            else { ksol1.BackColor = Color.White; ksol1.ForeColor = Color.Black; }

        }

        private void ksol2_TextChanged(object sender, EventArgs e)
        {
            if (ksol2.Text != "-") { ksol2.BackColor = Color.Green; ksol2.ForeColor = Color.White; }
            else { ksol2.BackColor = Color.White; ksol2.ForeColor = Color.Black; }

        }

        private void ksol3_TextChanged(object sender, EventArgs e)
        {
            if (ksol3.Text != "-") { ksol3.BackColor = Color.Green; ksol3.ForeColor = Color.White; }
            else { ksol3.BackColor = Color.White; ksol3.ForeColor = Color.Black; }

        }

        private void ksol4_TextChanged(object sender, EventArgs e)
        {
            if (ksol4.Text != "-") { ksol4.BackColor = Color.Green; ksol4.ForeColor = Color.White; }
            else { ksol4.BackColor = Color.White; ksol4.ForeColor = Color.Black; }
        }

        private void ksol5_TextChanged(object sender, EventArgs e)
        {
            if (ksol5.Text != "-") { ksol5.BackColor = Color.Green; ksol5.ForeColor = Color.White; }
            else { ksol5.BackColor = Color.White; ksol5.ForeColor = Color.Black; }

        }

        private void timer2000_Tick(object sender, EventArgs e)
        {
            Sinyal2000();
        }
        private void timer4000_Tick(object sender, EventArgs e)
        {
            Sinyal4000();
        }
        private void timer6000_Tick(object sender, EventArgs e)
        {
            Sinyal6000();
        }
        private void timer8000_Tick(object sender, EventArgs e)
        {
            Sinyal8000();
        }
        /////// 
        private void KemikControlTimer_Tick(object sender, EventArgs e)
        {
            VeriAl();
            timerkemik250.Start();
            KemikControlTimer.Stop();
        }
        private void timerkemik250_Tick(object sender, EventArgs e)
        {
            Kemik250();
        }
        private void timerkemik500_Tick(object sender, EventArgs e)
        {
            Kemik500();
        }
        private void timerkemik1000_Tick(object sender, EventArgs e)
        {
            Kemik1000();
        }
        private void timerkemik2000_Tick(object sender, EventArgs e)
        {
            Kemik2000();
        }
        private void timerkemik4000_Tick(object sender, EventArgs e)
        {
            Kemik4000();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
      
        private void Kontrol_Click(object sender, EventArgs e)
        {
            HavaControlTimer.Start();
            loading.Text = "Yükleniyor..";
        }


        public Form1()
        {
            InitializeComponent();
        }
        private void VeriAl()
        {  //SAĞ
            if (hsag1.Text == "-") { hr250 = 0; }
            else
            {
                hr250 = Convert.ToInt32(hsag1.Text);
            }
            
            if (hsag2.Text == "-") { hr500 = 0; }
            else
            {
                hr500 = Convert.ToInt32(hsag2.Text);
            }
            
            if (hsag3.Text == "-") { hr1000 = 0; }
            else
            {
                hr1000 = Convert.ToInt32(hsag3.Text);
            }

            if (hsag4.Text == "-") { hr2000 = 0; }
            else
            {
                hr2000 = Convert.ToInt32(hsag4.Text);
            }

            if (hsag5.Text == "-") { hr4000 = 0; }
            else
            {
                hr4000 = Convert.ToInt32(hsag5.Text);
            }

            if (hsag6.Text == "-") { hr6000 = 0; }
            else
            {
                hr6000 = Convert.ToInt32(hsag6.Text);
            }
            if (hsag7.Text == "-") { hr8000 = 0; }
            else
            {
                hr8000 = Convert.ToInt32(hsag7.Text);
            }
            //SOL

            if (hsol1.Text == "-") { hl250 = 0; }
            else
            {
                hl250 = Convert.ToInt32(hsol1.Text);
            }

            if (hsol2.Text == "-") { hl500 = 0; }
            else
            {
                hl500 = Convert.ToInt32(hsol2.Text);
            }

            if (hsol3.Text == "-") { hl1000 = 0; }
            else
            {
                hl1000 = Convert.ToInt32(hsol3.Text);
            }

            if (hsol4.Text == "-") { hl2000 = 0; }
            else
            {
                hl2000 = Convert.ToInt32(hsol4.Text);
            }

            if (hsol5.Text == "-") { hl4000 = 0; }
            else
            {
                hl4000 = Convert.ToInt32(hsol5.Text);
            }

            if (hsol6.Text == "-") { hl6000 = 0; }
            else
            {
                hl6000 = Convert.ToInt32(hsol6.Text);
            }

            if (hsol7.Text == "-") { hl8000 = 0; }
            else
            {
                hl8000 = Convert.ToInt32(hsol7.Text);
            }
            //KEMİK SAĞ
            if (ksag1.Text == "-") { kr250 = 0; }
            else
            {
                kr250 = Convert.ToInt32(ksag1.Text);
            }

            if (ksag2.Text == "-") { kr500 = 0; }
            else
            {
                kr500 = Convert.ToInt32(ksag2.Text);
            }

            if (ksag3.Text == "-") { kr1000 = 0; }
            else
            {
                kr1000 = Convert.ToInt32(ksag3.Text);
            }

            if (ksag4.Text == "-") { kr2000 = 0; }
            else
            {
                kr2000 = Convert.ToInt32(ksag4.Text);
            }

            if (ksag5.Text == "-") { kr4000 = 0; }
            else
            {
                kr4000 = Convert.ToInt32(ksag5.Text);
            }
            //KEMİK SOL
            if (ksol1.Text == "-") { kl250 = 0; }
            else
            {
                kl250 = Convert.ToInt32(ksol1.Text);
            }

            if (ksol2.Text == "-") { kl500 = 0; }
            else
            {
                kl500 = Convert.ToInt32(ksol2.Text);
            }

            if (ksol3.Text == "-") { kl1000 = 0; }
            else
            {
                kl1000 = Convert.ToInt32(ksol3.Text);
            }

            if (ksol4.Text == "-") { kl2000 = 0; }
            else
            {
                kl2000 = Convert.ToInt32(ksol4.Text);
            }

            if (ksol5.Text == "-") { kl4000 = 0; }
            else
            {
                kl4000 = Convert.ToInt32(ksol5.Text);
            }
           
        }
   

        private void SinyalGürültüPaneli(int Hertz, int kötükulak, int iyikulak)
        {
            
            SinyalGürültüPaneli sinyalForm = new SinyalGürültüPaneli();
            sinyalForm.Hertz.Text = Hertz.ToString();
            sinyalForm.CurrentStateHertz = Hertz;
            
            sinyalForm.kötüKulak.Text = kötükulak.ToString();
            sinyalForm.iyiKulak.Text = iyikulak.ToString();
            sinyalForm.eşik = kötükulak;
            sinyalForm.gürültü = iyikulak;
            sinyalForm.Show();
            timer250.Stop();
            timer500.Stop();
            timer1000.Stop();
            timer2000.Stop();
            timer4000.Stop();
            timer6000.Stop();
            timer8000.Stop();
            
        }

        private void Sinyal250() 
        {
            if (Math.Abs(hr250 - hl250) >= 40 && hsag1.Text != "-" && hsol1.Text != "-" )
            {
                if (hr250 > hl250) { SinyalGürültüPaneli(250, hr250, hl250); }
                else { SinyalGürültüPaneli(250, hl250, hr250); }
            }
            else if (Math.Abs(hr250 - kl250) >= 40 && Math.Abs(hl250 - kr250) >= 40 && hsag1.Text != "-" && hsol1.Text != "-" && ksol1.Text != "-" && ksag1.Text != "-")
            {
                if (hr250 >= hl250) { SinyalGürültüPaneli(250, hr250, hl250); }
                else
                {
                    SinyalGürültüPaneli(250, hl250, hr250);
                }
            }
            
            else if (Math.Abs(hr250 - kl250) >= 40 && hsag1.Text != "-" && ksol1.Text!="-")
            {
                SinyalGürültüPaneli(250, hr250, hl250);    
            }
            else if (Math.Abs(hl250 - kr250) >= 40 && hsol1.Text != "-" && ksag1.Text !="-")
            {
                SinyalGürültüPaneli(250, hl250, hr250);         
            }
            else 
            {
                timer250.Stop();
                timer500.Start();
            }
        }
        private void Sinyal500()
        {
            if (Math.Abs(hr500 - hl500) >= 40 && hsag2.Text != "-" && hsol2.Text != "-" )
            {
                if (hr500 > hl500) { SinyalGürültüPaneli(500, hr500, hl500); }
                else { SinyalGürültüPaneli(500, hl500, hr500); }
            }
            else if (Math.Abs(hr500 - kl500) >= 40 && Math.Abs(hl500 - kr500) >= 40 && hsag2.Text != "-" && hsol2.Text != "-" && ksol2.Text != "-" && ksag2.Text != "-")
            {
                if (hr500 >= hl250) { SinyalGürültüPaneli(500, hr500, hl500); }
                else
                {
                    SinyalGürültüPaneli(250, hl500, hr500);
                }
            }
            else if (Math.Abs(hr500 - kl500) >= 40 && hsag2.Text != "-" && ksol2.Text != "-")
            {
                SinyalGürültüPaneli(500, hr500, hl500); 
             }
            else if (Math.Abs(hl500 - kr500) >= 40 && hsol2.Text !="-" &&  ksag2.Text!= "-")
            {
               SinyalGürültüPaneli(500, hl500, hr500); 
            }
            else
            {
                timer500.Stop();
                timer1000.Start();
            }
        }
        private void Sinyal1000()
        {
            if (Math.Abs(hr1000 - hl1000) >= 40 && hsag3.Text != "-" && hsol3.Text != "-" )
            {
                if (hr1000 > hl1000) { SinyalGürültüPaneli(1000, hr1000, hl1000); }
                else { SinyalGürültüPaneli(1000, hl1000, hr1000); }
            }
            else if (Math.Abs(hr1000 - kl1000) >= 40 && Math.Abs(hl1000 - kr1000) >= 40 && hsag3.Text != "-" && hsol3.Text != "-" && ksol3.Text != "-" && ksag3.Text != "-")
            {
                if (hr1000 >= hl1000) { SinyalGürültüPaneli(1000, hr1000, hl1000); }
                else
                {
                    SinyalGürültüPaneli(1000, hl1000, hr1000);
                }
            }     
            else if (Math.Abs(hr1000 - kl1000) >= 40 && hsag3.Text != "-" && ksol3.Text != "-")
            {
               SinyalGürültüPaneli(1000, hr1000, hl1000); 
              
            }
            else if (Math.Abs(hl1000 - kr1000) >= 40 && hsol3.Text != "-" && ksag3.Text != "-")
            {
               SinyalGürültüPaneli(1000, hl1000, hr1000); 
         
            }
            else
            {
                timer1000.Stop();
                timer2000.Start();
            }
        }
        private void Sinyal2000()
        {
            if (Math.Abs(hr2000 - hl2000) >= 40 && hsag4.Text != "-" && hsol4.Text != "-" )
            {
                if (hr2000 > hl2000) { SinyalGürültüPaneli(2000, hr2000, hl2000); }
                else { SinyalGürültüPaneli(2000, hl2000, hr2000); }
            }
            else if (Math.Abs(hr2000 - kl2000) >= 40 && Math.Abs(hl2000 - kr2000) >= 40 && hsag4.Text != "-" && hsol4.Text != "-" && ksol4.Text != "-" && ksag4.Text != "-")
            {
                if (hr2000 >= hl2000) { SinyalGürültüPaneli(2000, hr2000, hl2000); }
                else
                {
                    SinyalGürültüPaneli(2000, hl2000, hr2000);
                }
            }
            
            else if (Math.Abs(hr2000 - kl2000) >= 40 && hsag4.Text != "-" && ksol4.Text != "-")
            {
                SinyalGürültüPaneli(2000, hr2000, hl2000);      
            }
            else if (Math.Abs(hl2000 - kr2000) >= 40 && hsol4.Text != "-" && ksag4.Text!= "-")
            {
                SinyalGürültüPaneli(2000, hl2000, hr2000);       
            }
            else
            {
                timer2000.Stop();
                timer4000.Start();
            }
        }
        private void Sinyal4000() 
        {
            if (Math.Abs(hr4000 - hl4000) >= 40 && hsag5.Text != "-" && hsol5.Text != "-" )
            {
                if (hr4000 > hl4000) { SinyalGürültüPaneli(4000, hr4000, hl4000); }
                else { SinyalGürültüPaneli(4000, hl4000, hr4000); }
            }
            else if (Math.Abs(hr4000 - kl4000) >= 40 && Math.Abs(hl4000 - kr4000) >= 40 && hsag5.Text != "-" && hsol5.Text != "-" && ksol5.Text != "-" && ksag5.Text != "-")
            {
                if (hr4000 >= hl4000) { SinyalGürültüPaneli(4000, hr4000, hl4000); }
                else
                {
                    SinyalGürültüPaneli(4000, hl4000, hr4000);
                }
            }
            
            
            else if (Math.Abs(hr4000 - kl4000) >= 40 && hsag5.Text != "-" && ksol5.Text != "-")
            {
                SinyalGürültüPaneli(4000, hr4000, hl4000); 
              
            }
            else if (Math.Abs(hl4000 - kr4000) >= 40 && hsol5.Text!= "-" && ksag5.Text != "-")
            {
                SinyalGürültüPaneli(4000, hl4000, hr4000); 
           
            }
            else
            {
                timer4000.Stop();
                timer6000.Start();
            }
        }
        private void Sinyal6000()
        {
            if (Math.Abs(hr6000 - hl6000) >= 40 && hsag6.Text!= "-" && hsol6.Text != "-")
            {
                if (hr6000 > hl6000) { SinyalGürültüPaneli(6000, hr6000, hl6000); }
                else { SinyalGürültüPaneli(6000, hl6000, hr6000); }
            }
            else
            {
                timer6000.Stop();
                timer8000.Start();
            }
        }
        private void Sinyal8000()
        {
            if (Math.Abs(hr8000 - hl8000) >= 40 && hsag7.Text!= "-" && hsol7.Text != "-")
            {
                if (hr8000 > hl8000) { SinyalGürültüPaneli(8000, hr8000, hl8000); }
                else { SinyalGürültüPaneli(8000, hl8000, hr8000); }
            }
            else
            {
                timer8000.Stop();
                KemikControlTimer.Start();
            }
        }
        private void Kemik250()
        {
            if (Math.Abs(hr250- kr250) >= 15 && Math.Abs(hl250 - kr250) >= 15 && hsag1.Text != "-" && hsol1.Text != "-" && ksag1.Text != "-" && ksol1.Text != "-")
            {
                if (hr250 >= hl250)
                {
                    KemikMaskeleSonuc(250, kr250, hl250);
                }
                else
                {
                    KemikMaskeleSonuc(250, kl250, hr250);
                }
            }
            else if (Math.Abs(hr250 - kr250) >= 15 && hsag1.Text!="-" && ksag1.Text!="-")
            {
                KemikMaskeleSonuc(250, kr250, hl250);
            }
            else if (Math.Abs(hl250 - kl250) >= 15 && hsol1.Text!="-" && ksol1.Text!="-")
            {
                KemikMaskeleSonuc(250, kl250, hr250);
            }
            else
            {
                timerkemik250.Stop();
                timerkemik500.Start();
            }
        }
        private void Kemik500()
        {
            if (Math.Abs(hr500 - kr500) >= 15 && Math.Abs(hl500 - kr500) >= 15 && hsag2.Text != "-" && hsol2.Text != "-" && ksag2.Text!="-" && ksol2.Text!="-")
            {
                if (hr500 >= hl500)
                {
                    KemikMaskeleSonuc(500, kr500, hl500);
                }
                else
                {
                    KemikMaskeleSonuc(500, kl500, hr500);
                }
            }
            else if (Math.Abs(hr500 - kr500) >= 15 && hsag2.Text != "-" && ksag2.Text != "-")
            {
                KemikMaskeleSonuc(500, kr500, hl500);
            }
            else if (Math.Abs(hl500 - kl500) >= 15 && hsol2.Text != "-" && ksol2.Text != "-")
            {
                KemikMaskeleSonuc(500, kl500, hr500);
            }
            else
            {
                timerkemik500.Stop();
                timerkemik1000.Start();
            }
        }
        private void Kemik1000()
        {
            if (Math.Abs(hr1000 - kr1000) >= 15 && Math.Abs(hl1000 - kr1000) >= 15 && hsag3.Text != "-" && hsol3.Text != "-" && ksag3.Text != "-" && ksol3.Text != "-")
            {
                if (hr1000 >= hl1000)
                {
                    KemikMaskeleSonuc(1000, kr1000, hl1000);
                }
                else
                {
                    KemikMaskeleSonuc(1000, kl1000, hr1000);
                }
            }
            else if (Math.Abs(hr1000 - kr1000) >= 15 && hsag3.Text != "-" && ksag3.Text != "-")
            {
                KemikMaskeleSonuc(1000, kr1000, hl1000);
            }
            else if (Math.Abs(hl1000 - kl1000) >= 15 && hsol3.Text != "-" && ksol3.Text != "-")
            {
                KemikMaskeleSonuc(1000, kl1000, hr1000);
            }
            else
            {
                timerkemik1000.Stop();
                timerkemik2000.Start();
            }
        }
        private void Kemik2000()
        {
            if (Math.Abs(hr2000 - kr2000) >= 15 && Math.Abs(hl2000 - kr2000) >= 15 && hsag4.Text != "-" && hsol4.Text != "-" && ksag4.Text != "-" && ksol4.Text != "-")
            {
                if (hr2000 >= hl2000)
                {
                    KemikMaskeleSonuc(2000, kr2000, hl2000);
                }
                else
                {
                    KemikMaskeleSonuc(2000, kl2000, hr2000);
                }
            }
            else if (Math.Abs(hr2000 - kr2000) >= 15 && hsag4.Text != "-" && ksag4.Text != "-") 
            {
                KemikMaskeleSonuc(2000, kr2000, hl2000);
            }
            else if (Math.Abs(hl2000 - kl2000) >= 15 && hsol4.Text != "-" && ksol4.Text != "-")
            {
                KemikMaskeleSonuc(2000, kl2000, hr2000);
            }
            else
            {
                timerkemik2000.Stop();
                timerkemik4000.Start();
            }
        }
        private void Kemik4000()
        {
            if (Math.Abs(hr4000 - kr4000) >= 15 && Math.Abs(hl4000 - kr4000) >= 15 && hsag5.Text != "-" && hsol5.Text != "-" && ksag5.Text != "-" && ksol5.Text != "-")
            {
                if (hr4000 >= hl4000)
                {
                    KemikMaskeleSonuc(4000, kr4000, hl4000);
                }
                else
                {
                    KemikMaskeleSonuc(4000, kl4000, hr4000);
                }
            }
            if (Math.Abs(hr4000 - kr4000) >= 15 && hsag5.Text != "-" && ksag5.Text != "-")
            {
                KemikMaskeleSonuc(4000, kr4000, hl4000);
            }
            else if (Math.Abs(hl4000 - kl4000) >= 15 && hsol5.Text != "-" && ksol5.Text != "-")
            {
                KemikMaskeleSonuc(4000, kl4000, hr4000);
            }
            else
            {
                timerkemik4000.Stop();
                loading.Text = "BİTTİ";
            }

        }

       
        private void KemikMaskeleSonuc(int Hertz,int KemikEşik,int HavaGürültü)
        {
            KemikYoluMaskeleme KemikForm = new KemikYoluMaskeleme();
            KemikForm.eşik = KemikEşik;
            KemikForm.gürültü = HavaGürültü;
            KemikForm.Hertz.Text = Hertz.ToString();
            KemikForm.CurrentStateHertz = Hertz;
            KemikForm.Show();
            timerkemik250.Stop();
            timerkemik500.Stop();
            timerkemik1000.Stop();
            timerkemik2000.Stop();
            timerkemik4000.Stop();
        }
       
    }
}