namespace WhackUrMole
{
    partial class Menu
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
            this.rulesLink = new System.Windows.Forms.Button();
            this.gameLink = new System.Windows.Forms.Button();
            this.recordBoardLink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rulesLink
            // 
            this.rulesLink.Location = new System.Drawing.Point(364, 177);
            this.rulesLink.Margin = new System.Windows.Forms.Padding(5);
            this.rulesLink.Name = "rulesLink";
            this.rulesLink.Size = new System.Drawing.Size(131, 42);
            this.rulesLink.TabIndex = 0;
            this.rulesLink.Text = "Правила";
            this.rulesLink.UseVisualStyleBackColor = true;
            this.rulesLink.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameLink
            // 
            this.gameLink.Location = new System.Drawing.Point(344, 110);
            this.gameLink.Name = "gameLink";
            this.gameLink.Size = new System.Drawing.Size(172, 59);
            this.gameLink.TabIndex = 1;
            this.gameLink.Text = "Почати гру";
            this.gameLink.UseVisualStyleBackColor = true;
            this.gameLink.Click += new System.EventHandler(this.gameLink_Click);
            // 
            // recordBoardLink
            // 
            this.recordBoardLink.Location = new System.Drawing.Point(278, 227);
            this.recordBoardLink.Name = "recordBoardLink";
            this.recordBoardLink.Size = new System.Drawing.Size(327, 59);
            this.recordBoardLink.TabIndex = 2;
            this.recordBoardLink.Text = "Дошка рекордів";
            this.recordBoardLink.UseVisualStyleBackColor = true;
            this.recordBoardLink.Click += new System.EventHandler(this.recordBoardLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть ім\'я:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(454, 70);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(100, 34);
            this.usernameInput.TabIndex = 4;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            this.usernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameInput_KeyPress);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 416);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordBoardLink);
            this.Controls.Add(this.gameLink);
            this.Controls.Add(this.rulesLink);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.Text = "Вдар крота!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rulesLink;
        private System.Windows.Forms.Button gameLink;
        private System.Windows.Forms.Button recordBoardLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameInput;
    }
}

