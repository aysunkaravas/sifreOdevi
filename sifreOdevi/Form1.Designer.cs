namespace sifreOdevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxkucuk = new CheckBox();
            checkBoxbuyuk = new CheckBox();
            checkBoxrakam = new CheckBox();
            checkBoxozel = new CheckBox();
            lblşifre = new Label();
            lbluzunluk = new Label();
            btnuret = new Button();
            numsıfresayısı = new NumericUpDown();
            numsıfreuzunluk = new NumericUpDown();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numsıfresayısı).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numsıfreuzunluk).BeginInit();
            SuspendLayout();
            // 
            // checkBoxkucuk
            // 
            checkBoxkucuk.AutoSize = true;
            checkBoxkucuk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxkucuk.Location = new Point(61, 42);
            checkBoxkucuk.Name = "checkBoxkucuk";
            checkBoxkucuk.Size = new Size(126, 29);
            checkBoxkucuk.TabIndex = 0;
            checkBoxkucuk.Text = "Küçük Harf";
            checkBoxkucuk.UseVisualStyleBackColor = true;
            // 
            // checkBoxbuyuk
            // 
            checkBoxbuyuk.AutoSize = true;
            checkBoxbuyuk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxbuyuk.Location = new Point(61, 78);
            checkBoxbuyuk.Name = "checkBoxbuyuk";
            checkBoxbuyuk.Size = new Size(126, 29);
            checkBoxbuyuk.TabIndex = 1;
            checkBoxbuyuk.Text = "Büyük Harf";
            checkBoxbuyuk.UseVisualStyleBackColor = true;
            // 
            // checkBoxrakam
            // 
            checkBoxrakam.AutoSize = true;
            checkBoxrakam.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxrakam.Location = new Point(61, 113);
            checkBoxrakam.Name = "checkBoxrakam";
            checkBoxrakam.Size = new Size(90, 29);
            checkBoxrakam.TabIndex = 2;
            checkBoxrakam.Text = "Rakam";
            checkBoxrakam.UseVisualStyleBackColor = true;
            // 
            // checkBoxozel
            // 
            checkBoxozel.AutoSize = true;
            checkBoxozel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxozel.Location = new Point(61, 148);
            checkBoxozel.Name = "checkBoxozel";
            checkBoxozel.Size = new Size(147, 29);
            checkBoxozel.TabIndex = 3;
            checkBoxozel.Text = "Özel Karakter";
            checkBoxozel.UseVisualStyleBackColor = true;
            // 
            // lblşifre
            // 
            lblşifre.AutoSize = true;
            lblşifre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblşifre.Location = new Point(61, 207);
            lblşifre.Name = "lblşifre";
            lblşifre.Size = new Size(116, 25);
            lblşifre.TabIndex = 4;
            lblşifre.Text = "Şifre Sayısı  :";
            // 
            // lbluzunluk
            // 
            lbluzunluk.AutoSize = true;
            lbluzunluk.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbluzunluk.Location = new Point(61, 285);
            lbluzunluk.Name = "lbluzunluk";
            lbluzunluk.Size = new Size(151, 25);
            lbluzunluk.TabIndex = 5;
            lbluzunluk.Text = "Şifre Uzunluğu  :";
            // 
            // btnuret
            // 
            btnuret.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnuret.Location = new Point(248, 343);
            btnuret.Name = "btnuret";
            btnuret.Size = new Size(201, 58);
            btnuret.TabIndex = 6;
            btnuret.Text = "ÜRET ";
            btnuret.UseVisualStyleBackColor = true;
            btnuret.Click += btnuret_Click;
            // 
            // numsıfresayısı
            // 
            numsıfresayısı.Location = new Point(270, 209);
            numsıfresayısı.Name = "numsıfresayısı";
            numsıfresayısı.Size = new Size(150, 27);
            numsıfresayısı.TabIndex = 10;
            // 
            // numsıfreuzunluk
            // 
            numsıfreuzunluk.Location = new Point(270, 287);
            numsıfreuzunluk.Name = "numsıfreuzunluk";
            numsıfreuzunluk.Size = new Size(150, 27);
            numsıfreuzunluk.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(577, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(291, 324);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(914, 523);
            Controls.Add(listBox1);
            Controls.Add(numsıfreuzunluk);
            Controls.Add(numsıfresayısı);
            Controls.Add(btnuret);
            Controls.Add(lbluzunluk);
            Controls.Add(lblşifre);
            Controls.Add(checkBoxozel);
            Controls.Add(checkBoxrakam);
            Controls.Add(checkBoxbuyuk);
            Controls.Add(checkBoxkucuk);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numsıfresayısı).EndInit();
            ((System.ComponentModel.ISupportInitialize)numsıfreuzunluk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxkucuk;
        private CheckBox checkBoxbuyuk;
        private CheckBox checkBoxrakam;
        private CheckBox checkBoxozel;
        private Label lblşifre;
        private Label lbluzunluk;
        private Button btnuret;
        private NumericUpDown numsıfresayısı;
        private NumericUpDown numsıfreuzunluk;
        private ListBox listBox1;
    }
}