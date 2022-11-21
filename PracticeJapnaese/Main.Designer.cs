
namespace JapanesePractice
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.hiraganaBut = new System.Windows.Forms.Button();
            this.gatakanaBut = new System.Windows.Forms.Button();
            this.tarJap_Label = new System.Windows.Forms.Label();
            this.select1_but = new System.Windows.Forms.Button();
            this.select2_but = new System.Windows.Forms.Button();
            this.select3_but = new System.Windows.Forms.Button();
            this.back_but = new System.Windows.Forms.Button();
            this.graph_but = new System.Windows.Forms.Button();
            this.backChange_but = new System.Windows.Forms.Button();
            this.mode_but = new System.Windows.Forms.Button();
            this.japan_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hiraganaBut
            // 
            this.hiraganaBut.Location = new System.Drawing.Point(120, 117);
            this.hiraganaBut.Name = "hiraganaBut";
            this.hiraganaBut.Size = new System.Drawing.Size(91, 45);
            this.hiraganaBut.TabIndex = 0;
            this.hiraganaBut.Text = "히라가나";
            this.hiraganaBut.UseVisualStyleBackColor = true;
            this.hiraganaBut.Click += new System.EventHandler(this.hiraganaBut_Click);
            // 
            // gatakanaBut
            // 
            this.gatakanaBut.Location = new System.Drawing.Point(267, 117);
            this.gatakanaBut.Name = "gatakanaBut";
            this.gatakanaBut.Size = new System.Drawing.Size(95, 45);
            this.gatakanaBut.TabIndex = 1;
            this.gatakanaBut.Text = "가타카나";
            this.gatakanaBut.UseVisualStyleBackColor = true;
            this.gatakanaBut.Click += new System.EventHandler(this.gatakanaBut_Click);
            // 
            // tarJap_Label
            // 
            this.tarJap_Label.AutoSize = true;
            this.tarJap_Label.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tarJap_Label.Location = new System.Drawing.Point(212, 58);
            this.tarJap_Label.Name = "tarJap_Label";
            this.tarJap_Label.Size = new System.Drawing.Size(50, 48);
            this.tarJap_Label.TabIndex = 2;
            this.tarJap_Label.Text = "d";
            this.tarJap_Label.Visible = false;
            // 
            // select1_but
            // 
            this.select1_but.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select1_but.Location = new System.Drawing.Point(79, 168);
            this.select1_but.Name = "select1_but";
            this.select1_but.Size = new System.Drawing.Size(80, 43);
            this.select1_but.TabIndex = 3;
            this.select1_but.Text = "1";
            this.select1_but.UseVisualStyleBackColor = true;
            this.select1_but.Visible = false;
            // 
            // select2_but
            // 
            this.select2_but.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select2_but.Location = new System.Drawing.Point(201, 168);
            this.select2_but.Name = "select2_but";
            this.select2_but.Size = new System.Drawing.Size(80, 43);
            this.select2_but.TabIndex = 4;
            this.select2_but.Text = "2";
            this.select2_but.UseVisualStyleBackColor = true;
            this.select2_but.Visible = false;
            // 
            // select3_but
            // 
            this.select3_but.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.select3_but.Location = new System.Drawing.Point(326, 168);
            this.select3_but.Name = "select3_but";
            this.select3_but.Size = new System.Drawing.Size(80, 43);
            this.select3_but.TabIndex = 5;
            this.select3_but.Text = "3";
            this.select3_but.UseVisualStyleBackColor = true;
            this.select3_but.Visible = false;
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(12, 12);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(51, 27);
            this.back_but.TabIndex = 6;
            this.back_but.Text = "Back";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Visible = false;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // graph_but
            // 
            this.graph_but.Location = new System.Drawing.Point(416, 12);
            this.graph_but.Name = "graph_but";
            this.graph_but.Size = new System.Drawing.Size(51, 27);
            this.graph_but.TabIndex = 7;
            this.graph_but.Text = "단어장";
            this.graph_but.UseVisualStyleBackColor = true;
            this.graph_but.Click += new System.EventHandler(this.graph_but_Click);
            // 
            // backChange_but
            // 
            this.backChange_but.Location = new System.Drawing.Point(12, 12);
            this.backChange_but.Name = "backChange_but";
            this.backChange_but.Size = new System.Drawing.Size(51, 27);
            this.backChange_but.TabIndex = 8;
            this.backChange_but.Text = "배경";
            this.backChange_but.UseVisualStyleBackColor = true;
            this.backChange_but.Click += new System.EventHandler(this.backChange_but_Click);
            // 
            // mode_but
            // 
            this.mode_but.Location = new System.Drawing.Point(12, 217);
            this.mode_but.Name = "mode_but";
            this.mode_but.Size = new System.Drawing.Size(79, 45);
            this.mode_but.TabIndex = 9;
            this.mode_but.Text = "쓰기모드";
            this.mode_but.UseVisualStyleBackColor = true;
            this.mode_but.Click += new System.EventHandler(this.mode_but_Click);
            // 
            // japan_input
            // 
            this.japan_input.Font = new System.Drawing.Font("궁서", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.japan_input.Location = new System.Drawing.Point(190, 175);
            this.japan_input.Name = "japan_input";
            this.japan_input.Size = new System.Drawing.Size(100, 32);
            this.japan_input.TabIndex = 10;
            this.japan_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.japan_input.Visible = false;
            this.japan_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.japan_input_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(479, 272);
            this.Controls.Add(this.japan_input);
            this.Controls.Add(this.mode_but);
            this.Controls.Add(this.backChange_but);
            this.Controls.Add(this.graph_but);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.select3_but);
            this.Controls.Add(this.select2_but);
            this.Controls.Add(this.select1_but);
            this.Controls.Add(this.tarJap_Label);
            this.Controls.Add(this.gatakanaBut);
            this.Controls.Add(this.hiraganaBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "일본어 외우기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hiraganaBut;
        private System.Windows.Forms.Button gatakanaBut;
        private System.Windows.Forms.Label tarJap_Label;
        private System.Windows.Forms.Button select1_but;
        private System.Windows.Forms.Button select2_but;
        private System.Windows.Forms.Button select3_but;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button graph_but;
        private System.Windows.Forms.Button backChange_but;
        private System.Windows.Forms.Button mode_but;
        private System.Windows.Forms.TextBox japan_input;
    }
}
