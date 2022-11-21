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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
        int backChangeCount = 0;
        Bitmap nowBackImage;

        List<char> cutJap = new List<char>();
        string[] cutJap_en;

        Button answelBut;
        Button[] selButs = new Button[3];

        string answel = "";
        bool isWriteMode = false;

        void NewJapaneseWord() // 일본어 문제 불러오기
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

        void ManageGame(string tarJap, string tarJap_en, bool isStart) // 게임 모드 (주관식, 객관식)
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
        private void graph_but_Click(object sender, EventArgs e) // 단어장 열기
        {
            Graph graph = new Graph();
            graph.Show();
        }

        private void answerBut_Click(object sender, EventArgs e) // 객관식 정답 버튼 이벤트
        {
            answelBut.Click -= answerBut_Click;
            answelBut = null;
            NewJapaneseWord();
        }

        private void backChange_but_Click(object sender, EventArgs e) // 배경 변경 이벤트
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "이미지 선택";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(savePath);
                if (!di.Exists)
                {
                    di.Create();
                }

                if (backChangeCount > 0)
                {
                    this.BackgroundImage.Dispose();
                    nowBackImage.Dispose();
                }

                string backImagesPath = $"{di}/backImage.jpeg";
                string selectedImagesPath = ofd.FileName;
                byte[] buffer = File.ReadAllBytes(selectedImagesPath);
                int len = Buffer.ByteLength(buffer);
                using(FileStream fs = new FileStream(backImagesPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)){
                    fs.Write(buffer, 0, len);
                    fs.Close();
                }

                try
                {
                    nowBackImage = new Bitmap(backImagesPath);
                    this.BackgroundImage = new Bitmap(nowBackImage, new Size(this.Width, this.Height));
                }
                catch (Exception e1)
                {
                    MessageBox.Show("해당 사진은 불가능합니다.");
                    File.Delete(backImagesPath);
                }

                backChangeCount++;
            }
        }

        private void mode_but_Click(object sender, EventArgs e) // 모드 변경 이벤트
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

        private void japan_input_KeyPress(object sender, KeyPressEventArgs e) // 주관식 일본어 입력 이벤트
        {
            if (answel.Equals(japan_input.Text))
            {
                NewJapaneseWord();
                japan_input.Text = "";
            }
        }

        private void hiraganaBut_Click(object sender, EventArgs e) // 히라가나 모드로 변경
        {
            ManageGame(hiragana, hiragana_en, true);
        }

        private void gatakanaBut_Click(object sender, EventArgs e) // 가타카나 모드로 변경
        {
            ManageGame(gatakana, gatakana_en, true);
        }

        private void back_but_Click(object sender, EventArgs e) // 뒤로가기 이벤트
        {
            ManageGame("", "", false);
        }

        private void Form1_Load(object sender, EventArgs e) // 처음 실행할 때
        {
            selButs[0] = select1_but;
            selButs[1] = select2_but;
            selButs[2] = select3_but;

            if (File.Exists(savePath + "/backImage.jpeg"))
            {
                try
                {
                    nowBackImage = new Bitmap(savePath + "/backImage.jpeg");
                    this.BackgroundImage = new Bitmap(nowBackImage, new Size(this.Width, this.Height));
                    backChangeCount++;
                } catch(Exception e1)
                {
                    File.Delete(savePath + "/backImage.jpeg");
                }
            }
        }

        private void butsCreate(bool initialButState, bool lateButState) // 기본설정
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

        public Main()
        {
            InitializeComponent();
        }
    }
}