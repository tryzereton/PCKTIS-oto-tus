using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;


namespace Autoit_KeyPresser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("User32.dll")]

        public static extern int SetForegroundWindow(IntPtr point);
       
                        
        AutoItX3 a = new AutoItX3();

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F6)
            {
                botuDurdur();
                label16.Text = "Bot F6 kullanılarak durduruldu.";
                return true;
             }
            if (Form.ModifierKeys == Keys.None && keyData == Keys.F7)
            {
                botuBaslat();
                label16.Text = "Bot F7 kullanılarak başlatıldı.";
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void processListe()
        {
            listView1.Items.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.Equals("svchost") || p.ProcessName.Equals("winlogon") ||
                    p.ProcessName.Equals("wininit"))
                {
                    continue;
                }
                else
                {
                    ListViewItem l1 = new ListViewItem(p.ProcessName);
                    l1.SubItems.Add(p.Id + "");
                    l1.SubItems.Add(p.MainWindowTitle);
                    listView1.Items.Add(l1);
                }
            }
        }
                
        public void penceremUstteDursun()
        {
            string pName = "";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    pName = listView1.Items[i].Text;
                    break;
                }
            }
            try
            {
                if (checkBox1.Checked)
                {
                    Process p = Process.GetProcessesByName(pName).FirstOrDefault();
                    IntPtr handle = p.MainWindowHandle;
                    SetForegroundWindow(handle);
                }
            }
            catch (Exception)
            {
                label16.Text = "LÜTFEN SOL TARAFTAN BİR PROGRAM SEÇİN VE TEKRAR DENEYİN.";
            }
            
            
           
        }

        private void timerAyarla()
        {
            try
            {
                if (!string.IsNullOrEmpty(s1.Text) && comboBox1.SelectedIndex == 1)
                {
                    timer1.Interval = Convert.ToInt32(s1.Text) * 1000;
                }
                else
                {
                    timer1.Interval = Convert.ToInt32(s1.Text);
                }
                if (!string.IsNullOrEmpty(s2.Text) && comboBox2.SelectedIndex == 1)
                {
                    timer2.Interval = Convert.ToInt32(s2.Text) * 1000;
                }
                else
                {
                    timer2.Interval = Convert.ToInt32(s2.Text);
                }
                if (!string.IsNullOrEmpty(s3.Text) && comboBox3.SelectedIndex == 1)
                {
                    timer3.Interval = Convert.ToInt32(s3.Text) * 1000;
                }
                else
                {
                    timer3.Interval = Convert.ToInt32(s3.Text);
                }
                if (!string.IsNullOrEmpty(s4.Text) && comboBox4.SelectedIndex == 1)
                {
                    timer4.Interval = Convert.ToInt32(s4.Text) * 1000;
                }
                else
                {
                    timer4.Interval = Convert.ToInt32(s4.Text);
                }
                if (!string.IsNullOrEmpty(s5.Text) && comboBox5.SelectedIndex == 1)
                {
                    timer5.Interval = Convert.ToInt32(s5.Text) * 1000;
                }
                else
                {
                    timer5.Interval = Convert.ToInt32(s5.Text);
                }
                if (!string.IsNullOrEmpty(s6.Text) && comboBox6.SelectedIndex == 1)
                {
                    timer6.Interval = Convert.ToInt32(s6.Text) * 1000;
                }
                else
                {
                    timer6.Interval = Convert.ToInt32(s6.Text);
                }
                if (!string.IsNullOrEmpty(s7.Text) && comboBox7.SelectedIndex == 1)
                {
                    timer7.Interval = Convert.ToInt32(s7.Text) * 1000;
                }
                else
                {
                    timer7.Interval = Convert.ToInt32(s7.Text);
                }
                if (!string.IsNullOrEmpty(s8.Text) && comboBox8.SelectedIndex == 1)
                {
                    timer8.Interval = Convert.ToInt32(s8.Text) * 000;
                }
                else
                {
                    timer8.Interval = Convert.ToInt32(s8.Text);
                }
                if (!string.IsNullOrEmpty(s9.Text) && comboBox9.SelectedIndex == 1)
                {
                    timer9.Interval = Convert.ToInt32(s9.Text) * 1000;
                }
                else
                {
                    timer9.Interval = Convert.ToInt32(s9.Text);
                }
                if (!string.IsNullOrEmpty(s10.Text) && comboBox10.SelectedIndex == 1)
                {
                    timer10.Interval = Convert.ToInt32(s10.Text) * 1000;
                }
                else
                {
                    timer10.Interval = Convert.ToInt32(s10.Text);
                }
                if (!string.IsNullOrEmpty(s11.Text) && comboBox11.SelectedIndex == 1)
                {
                    timer11.Interval = Convert.ToInt32(s11.Text) * 1000;
                }
                else
                {
                    timer11.Interval = Convert.ToInt32(s11.Text);
                }
                if (!string.IsNullOrEmpty(s12.Text) && comboBox12.SelectedIndex == 1)
                {
                    timer12.Interval = Convert.ToInt32(s12.Text) * 1000;
                }
                else
                {
                    timer12.Interval = Convert.ToInt32(s12.Text);
                }
                if (!string.IsNullOrEmpty(s13.Text) && comboBox13.SelectedIndex == 1)
                {
                    timer13.Interval = Convert.ToInt32(s13.Text) * 1000;
                }
                else
                {
                    timer13.Interval = Convert.ToInt32(s13.Text);
                }
                if (!string.IsNullOrEmpty(s14.Text) && comboBox14.SelectedIndex == 1)
                {
                    timer14.Interval = Convert.ToInt32(s14.Text) * 1000;
                }
                else
                {
                    timer14.Interval = Convert.ToInt32(s14.Text);
                }
                if (!string.IsNullOrEmpty(s15.Text) && comboBox15.SelectedIndex == 1)
                {
                    timer15.Interval = Convert.ToInt32(s15.Text) * 1000;
                }
                else
                {
                    timer15.Interval = Convert.ToInt32(s15.Text);
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void botuDurdur()
        {
            try
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                timer8.Enabled = false;
                timer9.Enabled = false;
                timer10.Enabled = false;
                timer11.Enabled = false;
                timer12.Enabled = false;
                timer13.Enabled = false;
                timer14.Enabled = false;
                timer15.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botuBaslat()
        {
            timerAyarla();
            if (!string.IsNullOrEmpty(textBox1.Text) && timer1.Enabled == false)
            {
                timer1.Start();
            }
            if (!string.IsNullOrEmpty(textBox2.Text) && timer2.Enabled == false)
            {
                timer2.Start();
            }
            if (!string.IsNullOrEmpty(textBox3.Text) && timer3.Enabled == false)
            {
                timer3.Start();
            }
            if (!string.IsNullOrEmpty(textBox4.Text) && timer4.Enabled == false)
            {
                timer4.Start();
            }
            if (!string.IsNullOrEmpty(textBox5.Text) && timer5.Enabled == false)
            {
                timer5.Start();
            }
            if (!string.IsNullOrEmpty(textBox6.Text) && timer6.Enabled == false)
            {
                timer6.Start();
            }
            if (!string.IsNullOrEmpty(textBox7.Text) && timer7.Enabled == false)
            {
                timer7.Start();
            }
            if (!string.IsNullOrEmpty(textBox8.Text) && timer8.Enabled == false)
            {
                timer8.Start();
            }
            if (!string.IsNullOrEmpty(textBox9.Text) && timer9.Enabled == false)
            {
                timer9.Start();
            }
            if (!string.IsNullOrEmpty(textBox10.Text) && timer10.Enabled == false)
            {
                timer10.Start();
            }
            if (!string.IsNullOrEmpty(textBox11.Text) && timer11.Enabled == false)
            {
                timer11.Start();
            }
            if (!string.IsNullOrEmpty(textBox12.Text) && timer12.Enabled == false)
            {
                timer12.Start();
            }
            if (!string.IsNullOrEmpty(textBox13.Text) && timer13.Enabled == false)
            {
                timer13.Start();
            }
            if (!string.IsNullOrEmpty(textBox14.Text) && timer14.Enabled == false)
            {
                timer14.Start();
            }
            if (!string.IsNullOrEmpty(textBox15.Text) && timer15.Enabled == false)
            {
                timer15.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            processListe();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;

         
            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            botuBaslat();
            label16.Text = "Bot başlatıldı.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botuDurdur();
            label16.Text = "Bot Durduruldu.";
        }

       
      
        private void button3_Click_1(object sender, EventArgs e)
        {
            processListe();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
                   
            if (textBox1.Text != "" && checkBox1.Checked)
            {
                penceremUstteDursun();
                System.Threading.Thread.Sleep(100);
                a.Send(textBox1.Text.ToLower());
            }
            else
            {
                a.Send(textBox1.Text.ToLower());
            }
        }


        private void timer15_Tick(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                a.Send(textBox15.Text.ToLower());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                a.Send(textBox2.Text.ToLower());
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                a.Send(textBox3.Text.ToLower());
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                a.Send(textBox4.Text.ToLower());
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                a.Send(textBox14.Text.ToLower());
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                a.Send(textBox13.Text.ToLower());
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                a.Send(textBox12.Text.ToLower());
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                a.Send(textBox5.Text.ToLower());
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                a.Send(textBox6.Text.ToLower());
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                a.Send(textBox7.Text.ToLower());
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                a.Send(textBox8.Text.ToLower());
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                a.Send(textBox9.Text.ToLower());
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                a.Send(textBox10.Text.ToLower());
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                a.Send(textBox11.Text.ToLower());
            }
        }

        private void botuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tumAlanlariTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();

            s1.Clear();
            s2.Clear();
            s3.Clear();
            s4.Clear();
            s5.Clear();
            s6.Clear();
            s7.Clear();
            s8.Clear();
            s9.Clear();
            s10.Clear();
            s11.Clear();
            s12.Clear();
            s13.Clear();
            s14.Clear();
            s15.Clear();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
        }

        private void tümAlanlarıTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tumAlanlariTemizle();               
        }

        private void botuÜstteTutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (botuÜstteTutToolStripMenuItem.Checked)
            {
                this.TopMost = true;
                
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tumAlanlariTemizle();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda h = new Hakkinda();
            h.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenProcess = "";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        secilenProcess = listView1.Items[i].Text;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(secilenProcess))
                {
                    Process p = Process.GetProcessesByName(secilenProcess).FirstOrDefault();
                    p.Kill();
                    processListe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\kalintitemizleyici.cmd");
                sw.WriteLine("@echo off");
                sw.WriteLine("@echo kalintilar temizleniyor...");
                sw.WriteLine("Timeout /t:3");
                sw.WriteLine("del /f /q /s %temp%\\PCKTIS\\*.*");
                sw.WriteLine("@echo islem tamamlandi.");
                sw.Close();
                if (File.Exists(Application.StartupPath + "\\kalintitemizleyici.cmd"))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = Application.StartupPath + "\\kalintitemizleyici.cmd";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                }
                
            }
            catch (Exception)
            {

            }
            
        }
    }

  
}
