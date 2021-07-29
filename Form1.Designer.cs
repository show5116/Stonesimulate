
namespace Stone
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.peon = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gak3 = new System.Windows.Forms.Button();
            this.gak2 = new System.Windows.Forms.Button();
            this.gak1 = new System.Windows.Forms.Button();
            this.silling = new System.Windows.Forms.Label();
            this.GoldIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NextS = new System.Windows.Forms.Button();
            this.ini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UseP = new System.Windows.Forms.Label();
            this.UseS = new System.Windows.Forms.Label();
            this.UseG = new System.Windows.Forms.Label();
            this.gak1_1 = new System.Windows.Forms.RadioButton();
            this.gak1_2 = new System.Windows.Forms.RadioButton();
            this.gak1_3 = new System.Windows.Forms.RadioButton();
            this.gak1_4 = new System.Windows.Forms.RadioButton();
            this.gak1_5 = new System.Windows.Forms.RadioButton();
            this.gak1_6 = new System.Windows.Forms.RadioButton();
            this.gak1_7 = new System.Windows.Forms.RadioButton();
            this.gak1_8 = new System.Windows.Forms.RadioButton();
            this.gak1_9 = new System.Windows.Forms.RadioButton();
            this.gak1_10 = new System.Windows.Forms.RadioButton();
            this.gak2_10 = new System.Windows.Forms.RadioButton();
            this.gak2_9 = new System.Windows.Forms.RadioButton();
            this.gak2_8 = new System.Windows.Forms.RadioButton();
            this.gak2_7 = new System.Windows.Forms.RadioButton();
            this.gak2_6 = new System.Windows.Forms.RadioButton();
            this.gak2_5 = new System.Windows.Forms.RadioButton();
            this.gak2_4 = new System.Windows.Forms.RadioButton();
            this.gak2_3 = new System.Windows.Forms.RadioButton();
            this.gak2_2 = new System.Windows.Forms.RadioButton();
            this.gak2_1 = new System.Windows.Forms.RadioButton();
            this.gak3_10 = new System.Windows.Forms.RadioButton();
            this.gak3_9 = new System.Windows.Forms.RadioButton();
            this.gak3_8 = new System.Windows.Forms.RadioButton();
            this.gak3_7 = new System.Windows.Forms.RadioButton();
            this.gak3_6 = new System.Windows.Forms.RadioButton();
            this.gak3_5 = new System.Windows.Forms.RadioButton();
            this.gak3_4 = new System.Windows.Forms.RadioButton();
            this.gak3_3 = new System.Windows.Forms.RadioButton();
            this.gak3_2 = new System.Windows.Forms.RadioButton();
            this.gak3_1 = new System.Windows.Forms.RadioButton();
            this.gak1T = new System.Windows.Forms.Label();
            this.gak2T = new System.Windows.Forms.Label();
            this.gak3T = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "확률 :";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(388, 45);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(27, 12);
            this.percent.TabIndex = 1;
            this.percent.Text = "75%";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3티어 영웅돌",
            "3티어 전설돌",
            "3티어 유물돌"});
            this.comboBox1.Location = new System.Drawing.Point(74, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // peon
            // 
            this.peon.AutoSize = true;
            this.peon.Font = new System.Drawing.Font("굴림", 11F);
            this.peon.Location = new System.Drawing.Point(453, 42);
            this.peon.Name = "peon";
            this.peon.Size = new System.Drawing.Size(15, 15);
            this.peon.TabIndex = 6;
            this.peon.Text = "7";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stone.Properties.Resources.silling;
            this.pictureBox4.Location = new System.Drawing.Point(570, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stone.Properties.Resources.gold1;
            this.pictureBox3.Location = new System.Drawing.Point(570, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stone.Properties.Resources.peon1;
            this.pictureBox1.Location = new System.Drawing.Point(474, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 31);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gak3
            // 
            this.gak3.Image = global::Stone.Properties.Resources.각인2;
            this.gak3.Location = new System.Drawing.Point(355, 266);
            this.gak3.Name = "gak3";
            this.gak3.Size = new System.Drawing.Size(75, 68);
            this.gak3.TabIndex = 4;
            this.gak3.UseVisualStyleBackColor = true;
            this.gak3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gak2
            // 
            this.gak2.Image = global::Stone.Properties.Resources.각인;
            this.gak2.Location = new System.Drawing.Point(355, 153);
            this.gak2.Name = "gak2";
            this.gak2.Size = new System.Drawing.Size(75, 69);
            this.gak2.TabIndex = 3;
            this.gak2.UseVisualStyleBackColor = true;
            this.gak2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gak1
            // 
            this.gak1.Image = global::Stone.Properties.Resources.각인;
            this.gak1.Location = new System.Drawing.Point(355, 71);
            this.gak1.Name = "gak1";
            this.gak1.Size = new System.Drawing.Size(75, 64);
            this.gak1.TabIndex = 2;
            this.gak1.UseVisualStyleBackColor = true;
            this.gak1.Click += new System.EventHandler(this.button1_Click);
            // 
            // silling
            // 
            this.silling.AutoSize = true;
            this.silling.Font = new System.Drawing.Font("굴림", 12F);
            this.silling.Location = new System.Drawing.Point(525, 41);
            this.silling.Name = "silling";
            this.silling.Size = new System.Drawing.Size(49, 16);
            this.silling.TabIndex = 11;
            this.silling.Text = "label2";
            // 
            // GoldIn
            // 
            this.GoldIn.Location = new System.Drawing.Point(494, 94);
            this.GoldIn.Name = "GoldIn";
            this.GoldIn.PasswordChar = '*';
            this.GoldIn.Size = new System.Drawing.Size(60, 21);
            this.GoldIn.TabIndex = 12;
            this.GoldIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GoldIn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "돌 선택";
            // 
            // NextS
            // 
            this.NextS.Location = new System.Drawing.Point(186, 42);
            this.NextS.Name = "NextS";
            this.NextS.Size = new System.Drawing.Size(61, 23);
            this.NextS.TabIndex = 14;
            this.NextS.Text = "다음 돌";
            this.NextS.UseVisualStyleBackColor = true;
            this.NextS.Click += new System.EventHandler(this.NextS_Click);
            // 
            // ini
            // 
            this.ini.Location = new System.Drawing.Point(253, 42);
            this.ini.Name = "ini";
            this.ini.Size = new System.Drawing.Size(63, 23);
            this.ini.TabIndex = 15;
            this.ini.Text = "초기화";
            this.ini.UseVisualStyleBackColor = true;
            this.ini.Click += new System.EventHandler(this.ini_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "사용 페온 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "사용 실링 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "사용 골드 :";
            // 
            // UseP
            // 
            this.UseP.AutoSize = true;
            this.UseP.Location = new System.Drawing.Point(536, 198);
            this.UseP.Name = "UseP";
            this.UseP.Size = new System.Drawing.Size(11, 12);
            this.UseP.TabIndex = 19;
            this.UseP.Text = "0";
            // 
            // UseS
            // 
            this.UseS.AutoSize = true;
            this.UseS.Location = new System.Drawing.Point(536, 238);
            this.UseS.Name = "UseS";
            this.UseS.Size = new System.Drawing.Size(11, 12);
            this.UseS.TabIndex = 20;
            this.UseS.Text = "0";
            // 
            // UseG
            // 
            this.UseG.AutoSize = true;
            this.UseG.Location = new System.Drawing.Point(536, 281);
            this.UseG.Name = "UseG";
            this.UseG.Size = new System.Drawing.Size(11, 12);
            this.UseG.TabIndex = 21;
            this.UseG.Text = "0";
            // 
            // gak1_1
            // 
            this.gak1_1.AutoSize = true;
            this.gak1_1.Enabled = false;
            this.gak1_1.Location = new System.Drawing.Point(44, 89);
            this.gak1_1.Name = "gak1_1";
            this.gak1_1.Size = new System.Drawing.Size(14, 13);
            this.gak1_1.TabIndex = 22;
            this.gak1_1.TabStop = true;
            this.gak1_1.UseVisualStyleBackColor = true;
            // 
            // gak1_2
            // 
            this.gak1_2.AutoSize = true;
            this.gak1_2.Enabled = false;
            this.gak1_2.Location = new System.Drawing.Point(64, 89);
            this.gak1_2.Name = "gak1_2";
            this.gak1_2.Size = new System.Drawing.Size(14, 13);
            this.gak1_2.TabIndex = 23;
            this.gak1_2.TabStop = true;
            this.gak1_2.UseVisualStyleBackColor = true;
            // 
            // gak1_3
            // 
            this.gak1_3.AutoSize = true;
            this.gak1_3.Enabled = false;
            this.gak1_3.Location = new System.Drawing.Point(84, 89);
            this.gak1_3.Name = "gak1_3";
            this.gak1_3.Size = new System.Drawing.Size(14, 13);
            this.gak1_3.TabIndex = 24;
            this.gak1_3.TabStop = true;
            this.gak1_3.UseVisualStyleBackColor = true;
            // 
            // gak1_4
            // 
            this.gak1_4.AutoSize = true;
            this.gak1_4.Enabled = false;
            this.gak1_4.Location = new System.Drawing.Point(104, 89);
            this.gak1_4.Name = "gak1_4";
            this.gak1_4.Size = new System.Drawing.Size(14, 13);
            this.gak1_4.TabIndex = 25;
            this.gak1_4.TabStop = true;
            this.gak1_4.UseVisualStyleBackColor = true;
            // 
            // gak1_5
            // 
            this.gak1_5.AutoSize = true;
            this.gak1_5.Enabled = false;
            this.gak1_5.Location = new System.Drawing.Point(124, 89);
            this.gak1_5.Name = "gak1_5";
            this.gak1_5.Size = new System.Drawing.Size(14, 13);
            this.gak1_5.TabIndex = 26;
            this.gak1_5.TabStop = true;
            this.gak1_5.UseVisualStyleBackColor = true;
            // 
            // gak1_6
            // 
            this.gak1_6.AutoSize = true;
            this.gak1_6.Enabled = false;
            this.gak1_6.Location = new System.Drawing.Point(144, 89);
            this.gak1_6.Name = "gak1_6";
            this.gak1_6.Size = new System.Drawing.Size(14, 13);
            this.gak1_6.TabIndex = 27;
            this.gak1_6.TabStop = true;
            this.gak1_6.UseVisualStyleBackColor = true;
            // 
            // gak1_7
            // 
            this.gak1_7.AutoSize = true;
            this.gak1_7.Enabled = false;
            this.gak1_7.Location = new System.Drawing.Point(164, 89);
            this.gak1_7.Name = "gak1_7";
            this.gak1_7.Size = new System.Drawing.Size(14, 13);
            this.gak1_7.TabIndex = 28;
            this.gak1_7.TabStop = true;
            this.gak1_7.UseVisualStyleBackColor = true;
            // 
            // gak1_8
            // 
            this.gak1_8.AutoSize = true;
            this.gak1_8.Enabled = false;
            this.gak1_8.Location = new System.Drawing.Point(184, 89);
            this.gak1_8.Name = "gak1_8";
            this.gak1_8.Size = new System.Drawing.Size(14, 13);
            this.gak1_8.TabIndex = 29;
            this.gak1_8.TabStop = true;
            this.gak1_8.UseVisualStyleBackColor = true;
            // 
            // gak1_9
            // 
            this.gak1_9.AutoSize = true;
            this.gak1_9.Enabled = false;
            this.gak1_9.Location = new System.Drawing.Point(204, 89);
            this.gak1_9.Name = "gak1_9";
            this.gak1_9.Size = new System.Drawing.Size(14, 13);
            this.gak1_9.TabIndex = 30;
            this.gak1_9.TabStop = true;
            this.gak1_9.UseVisualStyleBackColor = true;
            // 
            // gak1_10
            // 
            this.gak1_10.AutoSize = true;
            this.gak1_10.Enabled = false;
            this.gak1_10.Location = new System.Drawing.Point(224, 89);
            this.gak1_10.Name = "gak1_10";
            this.gak1_10.Size = new System.Drawing.Size(14, 13);
            this.gak1_10.TabIndex = 31;
            this.gak1_10.TabStop = true;
            this.gak1_10.UseVisualStyleBackColor = true;
            // 
            // gak2_10
            // 
            this.gak2_10.AutoSize = true;
            this.gak2_10.Enabled = false;
            this.gak2_10.Location = new System.Drawing.Point(224, 181);
            this.gak2_10.Name = "gak2_10";
            this.gak2_10.Size = new System.Drawing.Size(14, 13);
            this.gak2_10.TabIndex = 41;
            this.gak2_10.TabStop = true;
            this.gak2_10.UseVisualStyleBackColor = true;
            // 
            // gak2_9
            // 
            this.gak2_9.AutoSize = true;
            this.gak2_9.Enabled = false;
            this.gak2_9.Location = new System.Drawing.Point(204, 181);
            this.gak2_9.Name = "gak2_9";
            this.gak2_9.Size = new System.Drawing.Size(14, 13);
            this.gak2_9.TabIndex = 40;
            this.gak2_9.TabStop = true;
            this.gak2_9.UseVisualStyleBackColor = true;
            // 
            // gak2_8
            // 
            this.gak2_8.AutoSize = true;
            this.gak2_8.Enabled = false;
            this.gak2_8.Location = new System.Drawing.Point(184, 181);
            this.gak2_8.Name = "gak2_8";
            this.gak2_8.Size = new System.Drawing.Size(14, 13);
            this.gak2_8.TabIndex = 39;
            this.gak2_8.TabStop = true;
            this.gak2_8.UseVisualStyleBackColor = true;
            // 
            // gak2_7
            // 
            this.gak2_7.AutoSize = true;
            this.gak2_7.Enabled = false;
            this.gak2_7.Location = new System.Drawing.Point(164, 181);
            this.gak2_7.Name = "gak2_7";
            this.gak2_7.Size = new System.Drawing.Size(14, 13);
            this.gak2_7.TabIndex = 38;
            this.gak2_7.TabStop = true;
            this.gak2_7.UseVisualStyleBackColor = true;
            // 
            // gak2_6
            // 
            this.gak2_6.AutoSize = true;
            this.gak2_6.Enabled = false;
            this.gak2_6.Location = new System.Drawing.Point(144, 181);
            this.gak2_6.Name = "gak2_6";
            this.gak2_6.Size = new System.Drawing.Size(14, 13);
            this.gak2_6.TabIndex = 37;
            this.gak2_6.TabStop = true;
            this.gak2_6.UseVisualStyleBackColor = true;
            // 
            // gak2_5
            // 
            this.gak2_5.AutoSize = true;
            this.gak2_5.Enabled = false;
            this.gak2_5.Location = new System.Drawing.Point(124, 181);
            this.gak2_5.Name = "gak2_5";
            this.gak2_5.Size = new System.Drawing.Size(14, 13);
            this.gak2_5.TabIndex = 36;
            this.gak2_5.TabStop = true;
            this.gak2_5.UseVisualStyleBackColor = true;
            // 
            // gak2_4
            // 
            this.gak2_4.AutoSize = true;
            this.gak2_4.Enabled = false;
            this.gak2_4.Location = new System.Drawing.Point(104, 181);
            this.gak2_4.Name = "gak2_4";
            this.gak2_4.Size = new System.Drawing.Size(14, 13);
            this.gak2_4.TabIndex = 35;
            this.gak2_4.TabStop = true;
            this.gak2_4.UseVisualStyleBackColor = true;
            // 
            // gak2_3
            // 
            this.gak2_3.AutoSize = true;
            this.gak2_3.Enabled = false;
            this.gak2_3.Location = new System.Drawing.Point(84, 181);
            this.gak2_3.Name = "gak2_3";
            this.gak2_3.Size = new System.Drawing.Size(14, 13);
            this.gak2_3.TabIndex = 34;
            this.gak2_3.TabStop = true;
            this.gak2_3.UseVisualStyleBackColor = true;
            // 
            // gak2_2
            // 
            this.gak2_2.AutoSize = true;
            this.gak2_2.Enabled = false;
            this.gak2_2.Location = new System.Drawing.Point(64, 181);
            this.gak2_2.Name = "gak2_2";
            this.gak2_2.Size = new System.Drawing.Size(14, 13);
            this.gak2_2.TabIndex = 33;
            this.gak2_2.TabStop = true;
            this.gak2_2.UseVisualStyleBackColor = true;
            // 
            // gak2_1
            // 
            this.gak2_1.AutoSize = true;
            this.gak2_1.Enabled = false;
            this.gak2_1.Location = new System.Drawing.Point(44, 181);
            this.gak2_1.Name = "gak2_1";
            this.gak2_1.Size = new System.Drawing.Size(14, 13);
            this.gak2_1.TabIndex = 32;
            this.gak2_1.TabStop = true;
            this.gak2_1.UseVisualStyleBackColor = true;
            // 
            // gak3_10
            // 
            this.gak3_10.AutoSize = true;
            this.gak3_10.Enabled = false;
            this.gak3_10.Location = new System.Drawing.Point(224, 294);
            this.gak3_10.Name = "gak3_10";
            this.gak3_10.Size = new System.Drawing.Size(14, 13);
            this.gak3_10.TabIndex = 51;
            this.gak3_10.TabStop = true;
            this.gak3_10.UseVisualStyleBackColor = true;
            // 
            // gak3_9
            // 
            this.gak3_9.AutoSize = true;
            this.gak3_9.Enabled = false;
            this.gak3_9.Location = new System.Drawing.Point(204, 294);
            this.gak3_9.Name = "gak3_9";
            this.gak3_9.Size = new System.Drawing.Size(14, 13);
            this.gak3_9.TabIndex = 50;
            this.gak3_9.TabStop = true;
            this.gak3_9.UseVisualStyleBackColor = true;
            // 
            // gak3_8
            // 
            this.gak3_8.AutoSize = true;
            this.gak3_8.Enabled = false;
            this.gak3_8.Location = new System.Drawing.Point(184, 294);
            this.gak3_8.Name = "gak3_8";
            this.gak3_8.Size = new System.Drawing.Size(14, 13);
            this.gak3_8.TabIndex = 49;
            this.gak3_8.TabStop = true;
            this.gak3_8.UseVisualStyleBackColor = true;
            // 
            // gak3_7
            // 
            this.gak3_7.AutoSize = true;
            this.gak3_7.Enabled = false;
            this.gak3_7.Location = new System.Drawing.Point(164, 294);
            this.gak3_7.Name = "gak3_7";
            this.gak3_7.Size = new System.Drawing.Size(14, 13);
            this.gak3_7.TabIndex = 48;
            this.gak3_7.TabStop = true;
            this.gak3_7.UseVisualStyleBackColor = true;
            // 
            // gak3_6
            // 
            this.gak3_6.AutoSize = true;
            this.gak3_6.Enabled = false;
            this.gak3_6.Location = new System.Drawing.Point(144, 294);
            this.gak3_6.Name = "gak3_6";
            this.gak3_6.Size = new System.Drawing.Size(14, 13);
            this.gak3_6.TabIndex = 47;
            this.gak3_6.TabStop = true;
            this.gak3_6.UseVisualStyleBackColor = true;
            // 
            // gak3_5
            // 
            this.gak3_5.AutoSize = true;
            this.gak3_5.Enabled = false;
            this.gak3_5.Location = new System.Drawing.Point(124, 294);
            this.gak3_5.Name = "gak3_5";
            this.gak3_5.Size = new System.Drawing.Size(14, 13);
            this.gak3_5.TabIndex = 46;
            this.gak3_5.TabStop = true;
            this.gak3_5.UseVisualStyleBackColor = true;
            // 
            // gak3_4
            // 
            this.gak3_4.AutoSize = true;
            this.gak3_4.Enabled = false;
            this.gak3_4.Location = new System.Drawing.Point(104, 294);
            this.gak3_4.Name = "gak3_4";
            this.gak3_4.Size = new System.Drawing.Size(14, 13);
            this.gak3_4.TabIndex = 45;
            this.gak3_4.TabStop = true;
            this.gak3_4.UseVisualStyleBackColor = true;
            // 
            // gak3_3
            // 
            this.gak3_3.AutoSize = true;
            this.gak3_3.Enabled = false;
            this.gak3_3.Location = new System.Drawing.Point(84, 294);
            this.gak3_3.Name = "gak3_3";
            this.gak3_3.Size = new System.Drawing.Size(14, 13);
            this.gak3_3.TabIndex = 44;
            this.gak3_3.TabStop = true;
            this.gak3_3.UseVisualStyleBackColor = true;
            // 
            // gak3_2
            // 
            this.gak3_2.AutoSize = true;
            this.gak3_2.Enabled = false;
            this.gak3_2.Location = new System.Drawing.Point(64, 294);
            this.gak3_2.Name = "gak3_2";
            this.gak3_2.Size = new System.Drawing.Size(14, 13);
            this.gak3_2.TabIndex = 43;
            this.gak3_2.TabStop = true;
            this.gak3_2.UseVisualStyleBackColor = true;
            // 
            // gak3_1
            // 
            this.gak3_1.AutoSize = true;
            this.gak3_1.Enabled = false;
            this.gak3_1.Location = new System.Drawing.Point(44, 294);
            this.gak3_1.Name = "gak3_1";
            this.gak3_1.Size = new System.Drawing.Size(14, 13);
            this.gak3_1.TabIndex = 42;
            this.gak3_1.TabStop = true;
            this.gak3_1.UseVisualStyleBackColor = true;
            // 
            // gak1T
            // 
            this.gak1T.AutoSize = true;
            this.gak1T.Location = new System.Drawing.Point(278, 89);
            this.gak1T.Name = "gak1T";
            this.gak1T.Size = new System.Drawing.Size(11, 12);
            this.gak1T.TabIndex = 52;
            this.gak1T.Text = "0";
            // 
            // gak2T
            // 
            this.gak2T.AutoSize = true;
            this.gak2T.Location = new System.Drawing.Point(278, 181);
            this.gak2T.Name = "gak2T";
            this.gak2T.Size = new System.Drawing.Size(11, 12);
            this.gak2T.TabIndex = 53;
            this.gak2T.Text = "0";
            // 
            // gak3T
            // 
            this.gak3T.AutoSize = true;
            this.gak3T.Location = new System.Drawing.Point(278, 295);
            this.gak3T.Name = "gak3T";
            this.gak3T.Size = new System.Drawing.Size(11, 12);
            this.gak3T.TabIndex = 54;
            this.gak3T.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(536, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "인벤 샤틀키에";
            this.label6.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gak3T);
            this.Controls.Add(this.gak2T);
            this.Controls.Add(this.gak1T);
            this.Controls.Add(this.gak3_10);
            this.Controls.Add(this.gak3_9);
            this.Controls.Add(this.gak3_8);
            this.Controls.Add(this.gak3_7);
            this.Controls.Add(this.gak3_6);
            this.Controls.Add(this.gak3_5);
            this.Controls.Add(this.gak3_4);
            this.Controls.Add(this.gak3_3);
            this.Controls.Add(this.gak3_2);
            this.Controls.Add(this.gak3_1);
            this.Controls.Add(this.gak2_10);
            this.Controls.Add(this.gak2_9);
            this.Controls.Add(this.gak2_8);
            this.Controls.Add(this.gak2_7);
            this.Controls.Add(this.gak2_6);
            this.Controls.Add(this.gak2_5);
            this.Controls.Add(this.gak2_4);
            this.Controls.Add(this.gak2_3);
            this.Controls.Add(this.gak2_2);
            this.Controls.Add(this.gak2_1);
            this.Controls.Add(this.gak1_10);
            this.Controls.Add(this.gak1_9);
            this.Controls.Add(this.gak1_8);
            this.Controls.Add(this.gak1_7);
            this.Controls.Add(this.gak1_6);
            this.Controls.Add(this.gak1_5);
            this.Controls.Add(this.gak1_4);
            this.Controls.Add(this.gak1_3);
            this.Controls.Add(this.gak1_2);
            this.Controls.Add(this.gak1_1);
            this.Controls.Add(this.UseG);
            this.Controls.Add(this.UseS);
            this.Controls.Add(this.UseP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ini);
            this.Controls.Add(this.NextS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoldIn);
            this.Controls.Add(this.silling);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.peon);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gak3);
            this.Controls.Add(this.gak2);
            this.Controls.Add(this.gak1);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Button gak1;
        private System.Windows.Forms.Button gak2;
        private System.Windows.Forms.Button gak3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label peon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label silling;
        private System.Windows.Forms.TextBox GoldIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextS;
        private System.Windows.Forms.Button ini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UseP;
        private System.Windows.Forms.Label UseS;
        private System.Windows.Forms.Label UseG;
        private System.Windows.Forms.RadioButton gak1_1;
        private System.Windows.Forms.RadioButton gak1_2;
        private System.Windows.Forms.RadioButton gak1_3;
        private System.Windows.Forms.RadioButton gak1_4;
        private System.Windows.Forms.RadioButton gak1_5;
        private System.Windows.Forms.RadioButton gak1_6;
        private System.Windows.Forms.RadioButton gak1_7;
        private System.Windows.Forms.RadioButton gak1_8;
        private System.Windows.Forms.RadioButton gak1_9;
        private System.Windows.Forms.RadioButton gak1_10;
        private System.Windows.Forms.RadioButton gak2_10;
        private System.Windows.Forms.RadioButton gak2_9;
        private System.Windows.Forms.RadioButton gak2_8;
        private System.Windows.Forms.RadioButton gak2_7;
        private System.Windows.Forms.RadioButton gak2_6;
        private System.Windows.Forms.RadioButton gak2_5;
        private System.Windows.Forms.RadioButton gak2_4;
        private System.Windows.Forms.RadioButton gak2_3;
        private System.Windows.Forms.RadioButton gak2_2;
        private System.Windows.Forms.RadioButton gak2_1;
        private System.Windows.Forms.RadioButton gak3_10;
        private System.Windows.Forms.RadioButton gak3_9;
        private System.Windows.Forms.RadioButton gak3_8;
        private System.Windows.Forms.RadioButton gak3_7;
        private System.Windows.Forms.RadioButton gak3_6;
        private System.Windows.Forms.RadioButton gak3_5;
        private System.Windows.Forms.RadioButton gak3_4;
        private System.Windows.Forms.RadioButton gak3_3;
        private System.Windows.Forms.RadioButton gak3_2;
        private System.Windows.Forms.RadioButton gak3_1;
        private System.Windows.Forms.Label gak1T;
        private System.Windows.Forms.Label gak2T;
        private System.Windows.Forms.Label gak3T;
        private System.Windows.Forms.Label label6;
    }
}

