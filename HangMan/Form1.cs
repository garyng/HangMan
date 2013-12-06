using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HangMan
{
    public partial class frmMain : Form
    {
        string strUnprocessWordList = "";
        string strCurrentWord = "";
        List<Label> lblWords = new List<Label>();
        string strWrongChar = "";
        string strCorrectChar = "";
        int intCurrentBodyParts = 0;
        int intCorrectChar = 0;
        int intHintCount = 0;

        public frmMain()
        {
            InitializeComponent();

        }

        enum HangManBodyParts
        {
            Head,
            LeftEye,
            RightEye,
            Mouth,
            LeftArm,
            RightArm,
            Body,
            LeftLeg,
            RightLeg,
            All
        }

        void DrawBodyParts(HangManBodyParts bpBodyParts)
        {
            Bitmap bHangMan = (Bitmap)picHang.Image;
            Graphics gHangMan = Graphics.FromImage(picHang.Image); //pnlHang.CreateGraphics();
            Pen pHangMan = new Pen(Color.Blue, 3);
            if (bpBodyParts == HangManBodyParts.Head)
            {
                gHangMan.DrawEllipse(pHangMan, 40, 50, 40, 40);
            }
            else if (bpBodyParts == HangManBodyParts.LeftEye)
            {
                gHangMan.DrawEllipse(pHangMan, 50, 60, 5, 5);
            }
            else if (bpBodyParts == HangManBodyParts.RightEye)
            {
                gHangMan.DrawEllipse(pHangMan, 63, 60, 5, 5);
            }
            else if (bpBodyParts == HangManBodyParts.Mouth)
            {
                gHangMan.DrawArc(pHangMan, 50, 60, 20, 20, 45, 90);
            }
            else if (bpBodyParts == HangManBodyParts.Body)
            {
                gHangMan.DrawLine(pHangMan, new Point(60, 90), new Point(60, 170));
            }
            else if (bpBodyParts == HangManBodyParts.LeftArm)
            {
                gHangMan.DrawLine(pHangMan, new Point(60, 100), new Point(30, 85));
            }
            else if (bpBodyParts == HangManBodyParts.RightArm)
            {
                gHangMan.DrawLine(pHangMan, new Point(60, 100), new Point(90, 85));
            }
            else if (bpBodyParts == HangManBodyParts.LeftLeg)
            {
                gHangMan.DrawLine(pHangMan, new Point(60, 170), new Point(30, 190));
            }
            else if (bpBodyParts == HangManBodyParts.RightLeg)
            {
                gHangMan.DrawLine(pHangMan, new Point(60, 170), new Point(90, 190));
            }
            else if (bpBodyParts == HangManBodyParts.All)
            {
                gHangMan.DrawEllipse(pHangMan, 40, 50, 40, 40);
                gHangMan.DrawEllipse(pHangMan, 50, 60, 5, 5);
                gHangMan.DrawEllipse(pHangMan, 63, 60, 5, 5);
                gHangMan.DrawArc(pHangMan, 50, 60, 20, 20, 45, 90);
                gHangMan.DrawLine(pHangMan, new Point(60, 90), new Point(60, 170));
                gHangMan.DrawLine(pHangMan, new Point(60, 100), new Point(30, 85));
                gHangMan.DrawLine(pHangMan, new Point(60, 100), new Point(90, 85));
                gHangMan.DrawLine(pHangMan, new Point(60, 170), new Point(30, 190));
                gHangMan.DrawLine(pHangMan, new Point(60, 170), new Point(90, 190));
            }
            picHang.Image = bHangMan;
        }

        string GetRandomWord()
        {
            Random rnWord = new Random();
            string[] strWords = strUnprocessWordList.Split('\n');
            string strWord = strWords[rnWord.Next(0, strWords.Length - 1)];
            lblLength.Text = "Word's length: " + (strWord.Length - 1).ToString();
            return strWord;
        }

        void MakeLabels()
        {
            strCurrentWord = GetRandomWord();
            char[] chrCurrentWordChar = strCurrentWord.ToCharArray();
            int intPixelBetweenLabel = gbWord.Width / chrCurrentWordChar.Length - 1;
            for (int intCurrent = 0; intCurrent < chrCurrentWordChar.Length - 1; intCurrent++)
            {
                lblWords.Add(new Label());
                lblWords[intCurrent].Location = new Point(intCurrent * intPixelBetweenLabel + 10, 80);
                lblWords[intCurrent].Text = "_";
                lblWords[intCurrent].Parent = gbWord;
                lblWords[intCurrent].BringToFront();
                lblWords[intCurrent].CreateControl();
                lblWords[intCurrent].Font = new Font("Segoe UI", 12);
            }

        }

        void DrawHangPost()
        {
            Bitmap bHangMan = new Bitmap(picHang.Width, picHang.Height);
            Graphics gHangMan = Graphics.FromImage(bHangMan); //pnlHang.CreateGraphics();
            Pen pHangMan = new Pen(Brushes.Brown, 10);
            gHangMan.DrawLine(pHangMan, new Point(135, picHang.Location.X + picHang.Width + picHang.Height), new Point(135, 0));  //(135, pnlHang.Location.X + pnlHang.Width + pnlHang.Height), new Point(135, 0));
            gHangMan.DrawLine(pHangMan, new Point(135, 5), new Point(65, 5));
            gHangMan.DrawLine(pHangMan, new Point(60, 0), new Point(60, 50));
            picHang.Image = bHangMan;
        }

        void LoadDictionary(string strDictPath)
        {
            try
            {
                StreamReader srDict = new StreamReader(strDictPath);
                strUnprocessWordList = srDict.ReadToEnd();
                lblWordsCount.Text = strUnprocessWordList.Split('\n').Length + " Words Loaded @ " + strDictPath;
            }
            catch
            {
                MessageBox.Show("No Dictionary Available, Program Quits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        void RePlay(bool bLost)
        {
            gbStatus.Location = gbWord.Location;
            gbStatus.Size = gbWord.Size;
            lblWord.Size = gbWord.Size;
            gbStatus.Visible = true;
            lblWord.Text = "The Word Was: " + strCurrentWord;
            lblWord.Location = new Point(gbWord.Width / 2 - lblWord.Width / 2 + 10, gbWord.Height / 2 - lblWord.Height / 2 + 10);
            if (bLost == true)
            {
                lblStatus.Text = "X.X" + Environment.NewLine + "You Lose!";
                //MessageBox.Show("Opps, The Words Was : " + strCurrentWord, "You Lost");

            }
            else if (bLost == false)
            {
                lblStatus.Text = @"\^.^/" + Environment.NewLine + "You Won!";
                //MessageBox.Show("You WON!", "Congrats!");


            }
            txtLtr.Enabled = false;
            hintToolStripMenuItem.Enabled = false;
        }

        void Reset()
        {
            Bitmap bHangMan = new Bitmap(picHang.Width, picHang.Height);

            Graphics gPanel = Graphics.FromImage(bHangMan); //pnlHang.CreateGraphics();
            gPanel.Clear(picHang.BackColor);   //(pnlHang.BackColor);
            picHang.Image = bHangMan;

            lblCharWrong.Text = "";
            lblLength.Text = "";
            strCurrentWord = "";
            lblWords = new List<Label>();
            strWrongChar = "";
            intCurrentBodyParts = 0;
            intCorrectChar = 0;
            txtLtr.Enabled = true;
            gbStatus.Visible = false;
            strCorrectChar = "";
            intHintCount = 0;
            txtLtr.Focus();
            hintToolStripMenuItem.Enabled = true;
            MakeLabels();
            DrawHangPost();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            LoadDictionary(Application.StartupPath + @"\Dictionary.txt");
            //DrawBodyParts(HangManBodyParts.All);
            MakeLabels();
        }

        private void txtLtr_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLtr.Text == "") return;
            char chrInputChar = txtLtr.Text.ToLower().ToCharArray()[0];
            txtLtr.Text = "";
            if (!char.IsLetter(chrInputChar))
            {
                txtLtr.Text = "";
                return;
            }

            if (strCurrentWord.Contains(chrInputChar))
            {
                char[] chrCurrentWordArray = strCurrentWord.ToCharArray();
                for (int intCurrent = 0; intCurrent < chrCurrentWordArray.Length; intCurrent++)
                {
                    if (chrCurrentWordArray[intCurrent] == chrInputChar)
                    {
                        if (lblWords[intCurrent].Text != chrInputChar.ToString())
                        {
                            lblWords[intCurrent].Text = chrInputChar.ToString();
                            intCorrectChar++;
                            if (!strCorrectChar.Contains(chrInputChar))
                            {
                                strCorrectChar += chrInputChar.ToString();
                            }

                        }
                        if (intCorrectChar == strCurrentWord.Length - 1)
                        {
                            RePlay(false);
                        }
                    }
                }


            }
            else if (!strCurrentWord.Contains(chrInputChar))
            {
                if (!strWrongChar.Contains(chrInputChar))
                {
                    strWrongChar += chrInputChar.ToString();
                    lblCharWrong.Text += "  " + chrInputChar.ToString();
                    DrawBodyParts((HangManBodyParts)intCurrentBodyParts);
                    intCurrentBodyParts++;
                    if (intCurrentBodyParts > 8)
                    {

                        RePlay(true);
                    }
                }
            }



        }

        private void txtLtr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && (e.KeyCode == Keys.G))
            {
                MessageBox.Show(strCurrentWord);
            }
        }

        private void loadDictionaryuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT FILE with one words per line|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadDictionary(ofd.FileName);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Graphics gPanel = picHang.CreateGraphics();
            gPanel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Random rndChr = new Random();
            char[] chrCurrentWord = strCurrentWord.ToCharArray();

            if (strCorrectChar == "")
            {
                char chrRnd = chrCurrentWord[rndChr.Next(0, chrCurrentWord.Length - 1)];
                int intCurrent = 0;
                foreach (char chrCurrent in chrCurrentWord)
                {

                    if (chrCurrent == chrRnd)
                    {
                        lblWords[intCurrent].Text = chrCurrent.ToString();
                        //txtLtr_KeyUp(this, new KeyEventArgs((Keys)chrCurrent));
                        intCorrectChar++;
                        strCorrectChar += chrCurrent.ToString();
                    }
                    intCurrent++;
                }
            }
            else if (strCorrectChar != "")
            {
                //List<char> chr = new List<char>;
                char[] chrCorrect = strCorrectChar.ToArray();
                string strCurrentTmp = strCurrentWord;
                foreach (char chrCurrent in chrCorrect)
                {
                    strCurrentTmp = strCurrentTmp.Replace(chrCurrent.ToString(), "");
                }
                char chdRnd = strCurrentTmp.ToCharArray()[rndChr.Next(0, strCurrentTmp.ToCharArray().Length - 1)];
                int intCurrent = 0;
                foreach (char chrCurrent in chrCurrentWord)
                {
                    if (chrCurrent == chdRnd)
                    {
                        lblWords[intCurrent].Text = chrCurrent.ToString();
                        //txtLtr_KeyUp(this,new KeyEventArgs((Keys)chrCurrent));
                        intCorrectChar++;
                        strCorrectChar += chrCurrent.ToString();
                    }
                    intCurrent++;
                }

            }

            if (intCorrectChar == strCurrentWord.Length - 1)
            {
                RePlay(false);
            }

            intHintCount++;
            if ((intHintCount > 5) || (intCorrectChar > strCurrentWord.Length / 2))
            {
                hintToolStripMenuItem.Enabled = false;
            }
            //char[] chrWrong = strWrongChar.ToLower().ToCharArray();
            //string strWordTmp = strCurrentWord.ToLower();
            //string chrRemove = chrWrong[0].ToString();
            //MessageBox.Show(strWordTmp.Replace(chrRemove,""));


        }



    }


}
