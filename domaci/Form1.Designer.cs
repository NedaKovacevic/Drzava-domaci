namespace domaci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.bottomButton = new System.Windows.Forms.Button();
            this.insertB = new System.Windows.Forms.Button();
            this.updateB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.naziv = new System.Windows.Forms.Label();
            this.kontinent = new System.Windows.Forms.Label();
            this.glavniGrad = new System.Windows.Forms.Label();
            this.povrsina = new System.Windows.Forms.Label();
            this.brStan = new System.Windows.Forms.Label();
            this.tbBrS = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbGlgrad = new System.Windows.Forms.TextBox();
            this.tbKont = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topButton
            // 
            this.topButton.Location = new System.Drawing.Point(140, 615);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(140, 51);
            this.topButton.TabIndex = 0;
            this.topButton.Text = "<<";
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(362, 615);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(140, 51);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(578, 615);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(145, 51);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // bottomButton
            // 
            this.bottomButton.Location = new System.Drawing.Point(807, 615);
            this.bottomButton.Name = "bottomButton";
            this.bottomButton.Size = new System.Drawing.Size(151, 51);
            this.bottomButton.TabIndex = 3;
            this.bottomButton.Text = ">>";
            this.bottomButton.UseVisualStyleBackColor = true;
            this.bottomButton.Click += new System.EventHandler(this.bottomButton_Click);
            // 
            // insertB
            // 
            this.insertB.Location = new System.Drawing.Point(807, 128);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(151, 52);
            this.insertB.TabIndex = 4;
            this.insertB.Text = "insert";
            this.insertB.UseVisualStyleBackColor = true;
            this.insertB.Click += new System.EventHandler(this.insertB_Click);
            // 
            // updateB
            // 
            this.updateB.Location = new System.Drawing.Point(807, 260);
            this.updateB.Name = "updateB";
            this.updateB.Size = new System.Drawing.Size(151, 52);
            this.updateB.TabIndex = 5;
            this.updateB.Text = "update";
            this.updateB.UseVisualStyleBackColor = true;
            this.updateB.Click += new System.EventHandler(this.updateB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(807, 401);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(151, 52);
            this.deleteB.TabIndex = 6;
            this.deleteB.Text = "delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(134, 82);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(38, 32);
            this.id.TabIndex = 7;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // naziv
            // 
            this.naziv.AutoSize = true;
            this.naziv.Location = new System.Drawing.Point(134, 173);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(82, 32);
            this.naziv.TabIndex = 8;
            this.naziv.Text = "naziv";
            // 
            // kontinent
            // 
            this.kontinent.AutoSize = true;
            this.kontinent.Location = new System.Drawing.Point(134, 236);
            this.kontinent.Name = "kontinent";
            this.kontinent.Size = new System.Drawing.Size(132, 32);
            this.kontinent.TabIndex = 9;
            this.kontinent.Text = "kontinent";
            // 
            // glavniGrad
            // 
            this.glavniGrad.AutoSize = true;
            this.glavniGrad.Location = new System.Drawing.Point(134, 303);
            this.glavniGrad.Name = "glavniGrad";
            this.glavniGrad.Size = new System.Drawing.Size(155, 32);
            this.glavniGrad.TabIndex = 10;
            this.glavniGrad.Text = "glavni grad";
            // 
            // povrsina
            // 
            this.povrsina.AutoSize = true;
            this.povrsina.Location = new System.Drawing.Point(134, 385);
            this.povrsina.Name = "povrsina";
            this.povrsina.Size = new System.Drawing.Size(123, 32);
            this.povrsina.TabIndex = 11;
            this.povrsina.Text = "povrsina";
            // 
            // brStan
            // 
            this.brStan.AutoSize = true;
            this.brStan.Location = new System.Drawing.Point(134, 470);
            this.brStan.Name = "brStan";
            this.brStan.Size = new System.Drawing.Size(184, 32);
            this.brStan.TabIndex = 12;
            this.brStan.Text = "br stanovnika";
            // 
            // tbBrS
            // 
            this.tbBrS.Location = new System.Drawing.Point(441, 464);
            this.tbBrS.Name = "tbBrS";
            this.tbBrS.Size = new System.Drawing.Size(211, 38);
            this.tbBrS.TabIndex = 13;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(441, 369);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(211, 38);
            this.tbP.TabIndex = 14;
            // 
            // tbGlgrad
            // 
            this.tbGlgrad.Location = new System.Drawing.Point(441, 303);
            this.tbGlgrad.Name = "tbGlgrad";
            this.tbGlgrad.Size = new System.Drawing.Size(211, 38);
            this.tbGlgrad.TabIndex = 15;
            // 
            // tbKont
            // 
            this.tbKont.Location = new System.Drawing.Point(441, 233);
            this.tbKont.Name = "tbKont";
            this.tbKont.Size = new System.Drawing.Size(211, 38);
            this.tbKont.TabIndex = 16;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(441, 167);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(211, 38);
            this.tbNaziv.TabIndex = 17;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(441, 76);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(211, 38);
            this.tbid.TabIndex = 18;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(441, 533);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(210, 44);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 769);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbKont);
            this.Controls.Add(this.tbGlgrad);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbBrS);
            this.Controls.Add(this.brStan);
            this.Controls.Add(this.povrsina);
            this.Controls.Add(this.glavniGrad);
            this.Controls.Add(this.kontinent);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.id);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.updateB);
            this.Controls.Add(this.insertB);
            this.Controls.Add(this.bottomButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.topButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button bottomButton;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.Button updateB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.Label kontinent;
        private System.Windows.Forms.Label glavniGrad;
        private System.Windows.Forms.Label povrsina;
        private System.Windows.Forms.Label brStan;
        private System.Windows.Forms.TextBox tbBrS;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbGlgrad;
        private System.Windows.Forms.TextBox tbKont;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Button clearButton;
    }
}

