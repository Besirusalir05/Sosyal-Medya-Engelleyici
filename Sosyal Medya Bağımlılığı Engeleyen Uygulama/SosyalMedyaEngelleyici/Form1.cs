using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SosyalMedyaEngelleyici
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer;
        private Form xForm;
        private Timer soundTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeXForm();
            InitializeTimers();
            this.DoubleBuffered = true;
        }

        private void InitializeXForm()
        {
            xForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = Color.Black,
                Opacity = 5,
                TopMost = true,
                ShowInTaskbar = false
            };

            xForm.Paint += (sender, e) =>
            {
                
                using (Pen redPen = new Pen(Color.Red, 20))
                {
                    e.Graphics.DrawLine(redPen, 100, 100, xForm.Width - 100, xForm.Height - 100);
                    e.Graphics.DrawLine(redPen, xForm.Width - 100, 100, 100, xForm.Height - 100);
                }

                
                using (Font font = new Font("Arial", 48, FontStyle.Bold))
                {
                    e.Graphics.DrawString("ERİŞİM ENGELLENDİ!",
                                        font,
                                        Brushes.White,
                                        new PointF(xForm.Width / 2, xForm.Height / 2),
                                        new StringFormat { Alignment = StringAlignment.Center });
                }
            };

            xForm.Click += (sender, e) => HideXForm();
            xForm.FormClosing += (sender, e) => StopSound();
        }

        private void InitializeTimers()
        {
            
            soundTimer = new Timer { Interval = 3000 }; 
            soundTimer.Tick += (s, e) => PlayErrorSound();
        }

        private void btnFcbk_Click(object sender, EventArgs e)
        {
            BlockAccess("Facebook");
        }

        private void btnYtb_Click(object sender, EventArgs e)
        {
            BlockAccess("YouTube");
        }

        private void btnİns_Click(object sender, EventArgs e)
        {
            BlockAccess("Instagram");
        }

        private void BlockAccess(string siteName)
        {
            
            ShowXForm();

            
            PlayErrorSound();
            soundTimer.Start();

            
            MessageBox.Show($"{siteName} erişimi tamamen engellendi!", "Erişim Engeli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PlayErrorSound()
        {
            try
            {
                if (soundPlayer == null)
                {
                    soundPlayer = new SoundPlayer("error.wav");
                    soundPlayer.PlayLooping(); 
                }
                else
                {
                    soundPlayer.PlayLooping();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses çalınamadı: " + ex.Message);
            }
        }

        private void StopSound()
        {
            soundPlayer?.Stop();
            soundTimer.Stop();
        }

        private void ShowXForm()
        {
            xForm.Show();
        }

        private void HideXForm()
        {
            xForm.Hide();
            StopSound();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopSound();
            soundPlayer?.Dispose();
            xForm?.Dispose();
            soundTimer?.Dispose();
        }
    }
}