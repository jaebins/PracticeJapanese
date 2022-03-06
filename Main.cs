using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanesePractice
{
    public partial class Main : Form
    {
        string hiragana = "あかさたなはまやらわがざだばぱ" +
            "いきしちにひみりゐぎじぢびぴ" +
            "うくすつぬふむゆるぐずづぶぷ" +
            "えけせてねへめれゑげぜでべぺ" +
            "おこそとのほもよろをごぞどぼぽ" +
            "ゔん";
        string hiragana_en = "a ka sa ta na ha ma ya ra wa ga za da ba pa " +
            "i ki shi chi ni hi mi ri wi gi ji dji bi pi " +
            "u ku su tsu nu fu mu yu ru gu zu dzu bu pu " +
            "e ke se te ne he me re we ge ze de be pe " +
            "o ko so to no ho mo yo ro wo go zo do bo po " +
            "v n";
        string gatakana = "アカサタナイキシチニウクスツヌエケセテネオコソトノ" +
            "ヴンハマヤラヒミリフムユルヘメレホモヨロ" +
            "ワガザダバパヰギジヂビピグズヅブプヱゲゼデベペヲゴゾドボポ";
        string gatakana_en = "a ka sa ta na i ki shi chi ni u ku su tsu nu e ke se te ne o ko so to no v n " +
            "ha ma ya ra hi mi ri fu mu yu ru he me re ho mo yo ro " +
            "wa ga za da ba pa wi gi ji dji bi pi gu zu dzu bu pu " +
            "we ge ze de be pe wo go zo do bo po";

        Random ran = new Random();

        const int answelCount = 3;
        string savePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PracticeJap";
        int fileCount = 0;

        List<char> cutJap = new List<char>();
        string[] cutJap_en;

        Button answelBut;
        Button[] selButs = new Button[3];

        string answel = "";
        bool isWriteMode = false;

        public Main()
        {
            InitializeComponent();
        }

        void NewJapaneseWord()
        {
            butsCreate(false, true);
            int ranJap = ran.Next(0, cutJap.Count);
            tarJap_Label.Text = cutJap[ranJap].ToString();
            answel = cutJap_en[ranJap];
            Console.WriteLine("정답 : " + answel);

            if (!isWriteMode)
            {
                int ranAns = ran.Next(0, answelCount);
                for (int i = 0; i < answelCount; i++)
                {
                    if (i == ranAns)
                    {
                        answelBut = selButs[i];
                        selButs[i].Text = answel;
                        selButs[i].Click += answerBut_Click;
                    }
                    else
                    {
                        int ranNum = ran.Next(0, cutJap_en.Length);
                        selButs[i].Text = cutJap_en[ranNum];
                    }
                }
            }
        }

        void ManageGame(string tarJap, string tarJap_en, bool isStart)
        {
            if (isStart)
            {
                for (int i = 0; i < tarJap.Length; i++)
                {
                    cutJap.Add(tarJap[i]);
                }
                cutJap_en = tarJap_en.Split(' ');
                Console.WriteLine(cutJap.Count);
                Console.WriteLine(cutJap_en.Length);

                butsCreate(false, true);
                NewJapaneseWord();
            }
            else
            {
                cutJap.Clear();
                Array.Clear(cutJap_en, 0, cutJap_en.Length);
                butsCreate(true, false);
            }
        }

        private void butsCreate(bool initialButState, bool lateButState)
        {
            hiraganaBut.Visible = initialButState;
            gatakanaBut.Visible = initialButState;
            backChange_but.Visible = initialButState;
            tarJap_Label.Visible = lateButState;
            back_but.Visible = lateButState;
            if (isWriteMode)
            {
                select1_but.Visible = initialButState;
                select2_but.Visible = initialButState;
                select3_but.Visible = initialButState;
                japan_input.Visible = lateButState;
            }
            else
            {
                select1_but.Visible = lateButState;
                select2_but.Visible = lateButState;
                select3_but.Visible = lateButState;
                japan_input.Visible = initialButState;
            }
        }

        private void graph_but_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.Show();
        }

        private void answerBut_Click(object sender, EventArgs e)
        {
            answelBut.Click -= answerBut_Click;
            answelBut = null;
            NewJapaneseWord();
        }

        private void hiraganaBut_Click(object sender, EventArgs e)
        {
            ManageGame(hiragana, hiragana_en, true);
        }

        private void gatakanaBut_Click(object sender, EventArgs e)
        {
            ManageGame(gatakana, gatakana_en, true);
        }

        private void back_but_Click(object sender, EventArgs e)
        {
            ManageGame("", "", false);
        }

        private void backChange_but_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "이미지 선택";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png;";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = null;

                string tarPath = ofd.FileName;
                DirectoryInfo di = new DirectoryInfo(savePath);
                if (!di.Exists)
                {
                    di.Create();
                    DirectoryInfo di2 = new DirectoryInfo(savePath + "/usingImg");
                    di2.Create();
                }

                Size size = new Size(this.Width, this.Height);
                File.Copy(tarPath, savePath + "/target.png", true);
                Bitmap img;
                if (File.Exists(savePath + "/usingImg/target.png"))
                {
                    File.Copy(savePath + "/target.png", savePath + "/usingImg/"+ "target" + fileCount + ".png", true);
                    img = new Bitmap(new Bitmap(savePath + "/usingImg/" + "target" + fileCount + ".png"), size);
                }
                else
                {
                    File.Copy(savePath + "/target.png", savePath + "/usingImg/target.png", true);
                    img = new Bitmap(new Bitmap(savePath + "/usingImg/target.png"), size);
                }
                this.BackgroundImage = img;
                fileCount++;
            }
        }

        private void mode_but_Click(object sender, EventArgs e)
        {
            if (isWriteMode)
            {
                mode_but.Text = "쓰기모드";
                isWriteMode = false;
            }
            else
            {
                mode_but.Text = "읽기모드";
                isWriteMode = true;
            }
        }

        private void japan_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (answel.Equals(japan_input.Text))
            {
                NewJapaneseWord();
                japan_input.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selButs[0] = select1_but;
            selButs[1] = select2_but;
            selButs[2] = select3_but;

            if(File.Exists(savePath + "/usingImg/target.png"))
            {
                string[] fi = Directory.GetFiles(savePath + "/usingImg");
                for(int i = 0; i < fi.Length; i++)
                {
                    File.Delete(fi[i]);
                }
            }

            if (File.Exists(savePath + "/target.png"))
            {
                Size size = new Size(this.Width, this.Height);
                File.Copy(savePath + "/target.png", savePath + "/usingImg/target.png", true);
                Bitmap image = new Bitmap(new Bitmap(savePath + "/usingImg/target.png"), size);
                this.BackgroundImage = image;
            }
        }
    }
}
