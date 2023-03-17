namespace Opakovani4ITAMasterClassForDasAbitur
{
    partial class Mrizka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mrizkaCanvas1 = new Opakovani4ITAMasterClassForDasAbitur.MrizkaCanvas();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(12, 85);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 31);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(597, 51);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(212, 31);
            this.numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(597, 88);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(212, 31);
            this.numericUpDown4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pevně daný počet čtverečků";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pevně daná velikost čtverčků";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vykreslit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 71);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vykreslit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mrizkaCanvas1
            // 
            this.mrizkaCanvas1.BackColor = System.Drawing.Color.White;
            this.mrizkaCanvas1.Location = new System.Drawing.Point(12, 125);
            this.mrizkaCanvas1.Name = "mrizkaCanvas1";
            this.mrizkaCanvas1.Size = new System.Drawing.Size(960, 705);
            this.mrizkaCanvas1.TabIndex = 8;
            this.mrizkaCanvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.mrizkaCanvas1_Paint);
            this.mrizkaCanvas1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mrizkaCanvas1_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(413, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 29);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "šachovnice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Mrizka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 842);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mrizkaCanvas1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Mrizka";
            this.Text = "Mrizka";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private MrizkaCanvas mrizkaCanvas1;
        private CheckBox checkBox1;
    }
}