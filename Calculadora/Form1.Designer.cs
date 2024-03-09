namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.Imagens = new System.Windows.Forms.ImageList(this.components);
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSom = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.bbtnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ImageIndex = 2;
            this.btnFechar.ImageList = this.Imagens;
            this.btnFechar.Location = new System.Drawing.Point(462, -2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(65, 53);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imagens
            // 
            this.Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagens.ImageStream")));
            this.Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagens.Images.SetKeyName(0, "circle-xmark-regular.ico");
            this.Imagens.Images.SetKeyName(1, "circle-xmark-regular (1).png");
            this.Imagens.Images.SetKeyName(2, "circle-xmark-regular (1).png");
            this.Imagens.Images.SetKeyName(3, "0-solid.ico");
            this.Imagens.Images.SetKeyName(4, "1-solid.ico");
            this.Imagens.Images.SetKeyName(5, "2-solid.ico");
            this.Imagens.Images.SetKeyName(6, "3-solid.ico");
            this.Imagens.Images.SetKeyName(7, "4-solid.ico");
            this.Imagens.Images.SetKeyName(8, "5-solid.ico");
            this.Imagens.Images.SetKeyName(9, "6-solid.ico");
            this.Imagens.Images.SetKeyName(10, "7-solid.ico");
            this.Imagens.Images.SetKeyName(11, "8-solid.ico");
            this.Imagens.Images.SetKeyName(12, "9-solid.ico");
            this.Imagens.Images.SetKeyName(13, "calculator-solid.ico");
            this.Imagens.Images.SetKeyName(14, "c-solid.ico");
            this.Imagens.Images.SetKeyName(15, "divide-solid.ico");
            this.Imagens.Images.SetKeyName(16, "minus-solid.ico");
            this.Imagens.Images.SetKeyName(17, "percent-solid.ico");
            this.Imagens.Images.SetKeyName(18, "plus-minus-solid.ico");
            this.Imagens.Images.SetKeyName(19, "plus-solid.ico");
            this.Imagens.Images.SetKeyName(20, "xmark-solid.ico");
            this.Imagens.Images.SetKeyName(21, "delete-left-solid.ico");
            this.Imagens.Images.SetKeyName(22, "equals-solid.ico");
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoEllipsis = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(-1, 108);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(528, 189);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDisplay.Click += new System.EventHandler(this.label2_Click);
            this.lblDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblDisplay_MouseClick);
            this.lblDisplay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lblDisplay_PreviewKeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn4.FlatAppearance.BorderSize = 3;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 399);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 81);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.BorderSize = 3;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(102, 399);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 81);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.BorderSize = 3;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(192, 399);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 81);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSom
            // 
            this.btnSom.BackColor = System.Drawing.Color.White;
            this.btnSom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSom.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSom.FlatAppearance.BorderSize = 3;
            this.btnSom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnSom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnSom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSom.ImageIndex = 19;
            this.btnSom.ImageList = this.Imagens;
            this.btnSom.Location = new System.Drawing.Point(282, 312);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(84, 81);
            this.btnSom.TabIndex = 8;
            this.btnSom.UseVisualStyleBackColor = false;
            this.btnSom.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.White;
            this.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSub.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSub.FlatAppearance.BorderSize = 3;
            this.btnSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ImageIndex = 16;
            this.btnSub.ImageList = this.Imagens;
            this.btnSub.Location = new System.Drawing.Point(282, 399);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(84, 81);
            this.btnSub.TabIndex = 9;
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn1.FlatAppearance.BorderSize = 3;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 486);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 81);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.BorderSize = 3;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(102, 486);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 81);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.BorderSize = 3;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(192, 486);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 81);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.White;
            this.btnInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInt.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInt.FlatAppearance.BorderSize = 3;
            this.btnInt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnInt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.ImageIndex = 18;
            this.btnInt.ImageList = this.Imagens;
            this.btnInt.Location = new System.Drawing.Point(12, 573);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(84, 81);
            this.btnInt.TabIndex = 13;
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn0.FlatAppearance.BorderSize = 3;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(102, 573);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 81);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.White;
            this.btnVirgula.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnVirgula.FlatAppearance.BorderSize = 3;
            this.btnVirgula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnVirgula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(192, 573);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(84, 81);
            this.btnVirgula.TabIndex = 15;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn7.FlatAppearance.BorderSize = 3;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ImageIndex = 10;
            this.btn7.Location = new System.Drawing.Point(12, 312);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 81);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn8.FlatAppearance.BorderSize = 3;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(102, 312);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 81);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn9.FlatAppearance.BorderSize = 3;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(192, 312);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 81);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // bbtnMult
            // 
            this.bbtnMult.BackColor = System.Drawing.Color.White;
            this.bbtnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bbtnMult.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.bbtnMult.FlatAppearance.BorderSize = 3;
            this.bbtnMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.bbtnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.bbtnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bbtnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnMult.ImageIndex = 20;
            this.bbtnMult.ImageList = this.Imagens;
            this.bbtnMult.Location = new System.Drawing.Point(282, 486);
            this.bbtnMult.Name = "bbtnMult";
            this.bbtnMult.Size = new System.Drawing.Size(84, 81);
            this.bbtnMult.TabIndex = 19;
            this.bbtnMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bbtnMult.UseVisualStyleBackColor = false;
            this.bbtnMult.Click += new System.EventHandler(this.bbtnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDiv.FlatAppearance.BorderSize = 3;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ImageIndex = 15;
            this.btnDiv.ImageList = this.Imagens;
            this.btnDiv.Location = new System.Drawing.Point(282, 573);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(84, 81);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.FlatAppearance.BorderSize = 3;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.ImageKey = "delete-left-solid.ico";
            this.btnLimpar.ImageList = this.Imagens;
            this.btnLimpar.Location = new System.Drawing.Point(372, 312);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLimpar.Size = new System.Drawing.Size(142, 81);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageIndex = 14;
            this.btnCancelar.ImageList = this.Imagens;
            this.btnCancelar.Location = new System.Drawing.Point(372, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 81);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.White;
            this.btnDividir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDividir.FlatAppearance.BorderSize = 2;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GhostWhite;
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ImageIndex = 17;
            this.btnDividir.ImageList = this.Imagens;
            this.btnDividir.Location = new System.Drawing.Point(372, 486);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(142, 81);
            this.btnDividir.TabIndex = 23;
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEqual.FlatAppearance.BorderSize = 5;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ImageIndex = 22;
            this.btnEqual.ImageList = this.Imagens;
            this.btnEqual.Location = new System.Drawing.Point(372, 573);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(142, 81);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoEllipsis = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(-1, 120);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(515, 55);
            this.lblConta.TabIndex = 25;
            this.lblConta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblConta.Click += new System.EventHandler(this.lblConta_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ImageIndex = 16;
            this.btnMin.ImageList = this.Imagens;
            this.btnMin.Location = new System.Drawing.Point(400, -2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(65, 53);
            this.btnMin.TabIndex = 26;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(526, 666);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.bbtnMult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSom);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button bbtnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ImageList Imagens;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button btnMin;
    }
}

