using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskelemeAsistanıProjesi
{   
    public partial class SinyalGürültüPaneli : Form
    {   public int eşik, gürültü;
        public int rate;
        public int süre = 5,duydu=0;
        public bool state = true;
        public int CurrentStateHertz;
        public SinyalGürültüPaneli()
        {
            InitializeComponent();
        }

        private void SinyalGürültüPaneli_Load(object sender, EventArgs e)
        {
            sayac.Interval = 1000;
        }

        public void Kapat_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var forms in Application.OpenForms)
                {
                    Form1 f1 = forms as Form1;

                    if (f1 != null)
                    {
                        if (CurrentStateHertz == 250)
                        {
                            f1.timer500.Start();
                        }
                        if (CurrentStateHertz == 500)
                        {
                            f1.timer1000.Start();
                        }
                        if (CurrentStateHertz == 1000)
                        {
                            f1.timer2000.Start();
                        }
                        if (CurrentStateHertz == 2000)
                        {
                            f1.timer4000.Start();
                        }
                        if (CurrentStateHertz == 4000)
                        {
                            f1.timer6000.Start();
                        }
                        if (CurrentStateHertz == 6000)
                        {
                            f1.timer8000.Start();
                        }
                        if (CurrentStateHertz == 8000)
                        {
                            f1.KemikControlTimer.Start();
                        }
                    }
                }
            }
            catch (Exception ex) { }
            this.Close();

        }
        private void KontrolStart() 
        {
            if (startadd10.Checked) { gürültü += 10; }
            else if (startadd15.Checked) { gürültü += 15; }
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            if (duydu >= 4) { SonucLabel.Text = "Sonuç Eşik:" + eşik; sayac.Stop(); }
            else
            {
                mevcutGürültü.Text = gürültü.ToString();
                mevcutEşik.Text = eşik.ToString();

                duyduButton.Visible = false;
                duymadıButton.Visible = false;
                süre--;
                time.Text = süre.ToString();
                if (süre == 0)
                {
                    sayac.Stop();
                    süre = 5;
                    duyduButton.Visible = true;
                    duymadıButton.Visible = true;
                }
            }
        }

        private void duyduButton_Click(object sender, EventArgs e)
        {
            
            mevcutGürültü.Text = gürültü.ToString();
            KontrolAdd(); 
            sayac.Start(); 
            duydu++;
        }

        private void duymadıButton_Click(object sender, EventArgs e)
        {
            duydu = 0;
            KontrolEşik();
            mevcutEşik.Text = eşik.ToString();
            sayac.Start();
        }

        private void KontrolAdd() 
        {
            if (add5.Checked) { gürültü+= 5; }
            else if (add10.Checked) { gürültü+= 10; }
        }
        private void KontrolEşik() 
        {
            if (add5.Checked) { eşik += 5; }
            else if (add10.Checked) { eşik += 10; }
        }

        private void MaskelemeButton_Click(object sender, EventArgs e)
        {
            KontrolStart();
            GürültüBaslangıc.Enabled = false;
            GürültüArtış.Enabled = false;

            mevcutEşik.Visible = true;
            mevcutGürültü.Visible = true;
            eşikLabel.Visible = true;
            gürültüLabel.Visible = true;

            mevcutGürültü.Text = gürültü.ToString();
            mevcutEşik.Text = eşik.ToString();
            time.Visible = true;
            sayac.Start();

        }
    }
}
