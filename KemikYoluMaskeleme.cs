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
    public partial class KemikYoluMaskeleme : Form
    {
        public int eşik, gürültü;
        public int rate;
        public int süre = 5, duydu = 0;
        public int CurrentStateHertz;

        private void duyduButton_Click(object sender, EventArgs e)
        {
            duydu++;
            gürültüDeğeri.Text = gürültü.ToString();
            KontrolAdd();
            sayac.Start();
            
        }

        private void duymadıButton_Click(object sender, EventArgs e)
        {
            duydu = 0;
            KontrolEşik();
            eşikDeğeri.Text = eşik.ToString();
            sayac.Start();
        }
        private void KontrolAdd()
        {
            if (add5.Checked) { gürültü += 5; }
            else if (add10.Checked) { gürültü += 10; }
        }
        private void KontrolEşik()
        {
            if (add5.Checked) { eşik += 5; }
            else if (add10.Checked) { eşik += 10; }
        }
        private void MaskelemeButton_Click(object sender, EventArgs e)
        {
            KontrolStart();
            OklüzyonGroup.Enabled = false;
            GürültüArtışGroup.Enabled = false;
            GürültüGroup.Enabled = false;
            sayac.Start();
        }

        private void KontrolStart()
        {
            if (startAdd10.Checked) { gürültü += 10; }
            if (startAdd15.Checked) { gürültü += 15; }
         
            if (ok0.Checked)  { gürültü += 0; }
            if (ok10.Checked) { gürültü += 10; }
            if (ok15.Checked) { gürültü += 15; }
            if (ok20.Checked) { gürültü += 20; }
            if (ok25.Checked) { gürültü += 25; }

            gürültüDeğeri.Text = gürültü.ToString();
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            if (duydu >= 4) { SonucLabel.Text = "Sonuç Eşik:" + eşik; sayac.Stop(); }
            else
            {
                time.Visible = true;
                gürültüDeğeri.Text = gürültü.ToString();
                eşikDeğeri.Text = eşik.ToString();

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

        private void Kapat_Click(object sender, EventArgs e)
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
                            f1.timerkemik500.Start();
                        }
                        if (CurrentStateHertz == 500)
                        {
                            f1.timerkemik1000.Start();
                        }
                        if (CurrentStateHertz == 1000)
                        {
                            f1.timerkemik2000.Start();
                        }
                        if (CurrentStateHertz == 2000)
                        {
                            f1.timerkemik4000.Start();
                        }
                        if (CurrentStateHertz  == 4000)
                        {
                            f1.loading.Text = "BİTTİ";
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 

            }
           
            this.Close();
        }

        public KemikYoluMaskeleme()
        {
            InitializeComponent();
        }

        private void KemikYoluMaskeleme_Load(object sender, EventArgs e)
        {
            eşikDeğeri.Text = eşik.ToString();
            gürültüDeğeri.Text = gürültü.ToString();
            time.Visible = false;
            duyduButton.Visible = false;
            duymadıButton.Visible = false;
        }
    }
}
