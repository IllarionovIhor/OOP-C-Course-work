using System.Drawing;
using System.Windows.Forms;

namespace WhackUrMole
{
    partial class GameForm : Form
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.hardDiffButton = new System.Windows.Forms.Button();
            this.middleDiffButton = new System.Windows.Forms.Button();
            this.easyDiffButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.Transparent;
            this.Canvas.Controls.Add(this.label5);
            this.Canvas.Controls.Add(this.hardDiffButton);
            this.Canvas.Controls.Add(this.middleDiffButton);
            this.Canvas.Controls.Add(this.easyDiffButton);
            this.Canvas.Location = new System.Drawing.Point(198, 13);
            this.Canvas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(350, 350);
            this.Canvas.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оберіть важкість!";
            // 
            // hardDiffButton
            // 
            this.hardDiffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardDiffButton.Location = new System.Drawing.Point(104, 229);
            this.hardDiffButton.Margin = new System.Windows.Forms.Padding(5);
            this.hardDiffButton.Name = "hardDiffButton";
            this.hardDiffButton.Size = new System.Drawing.Size(141, 42);
            this.hardDiffButton.TabIndex = 2;
            this.hardDiffButton.Text = "Висока важкість";
            this.hardDiffButton.UseVisualStyleBackColor = true;
            this.hardDiffButton.Click += new System.EventHandler(this.hardDiffButton_Click);
            // 
            // middleDiffButton
            // 
            this.middleDiffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleDiffButton.Location = new System.Drawing.Point(104, 177);
            this.middleDiffButton.Margin = new System.Windows.Forms.Padding(5);
            this.middleDiffButton.Name = "middleDiffButton";
            this.middleDiffButton.Size = new System.Drawing.Size(141, 42);
            this.middleDiffButton.TabIndex = 1;
            this.middleDiffButton.Text = "Середня важкість";
            this.middleDiffButton.UseVisualStyleBackColor = true;
            this.middleDiffButton.Click += new System.EventHandler(this.middleDiffButton_Click);
            // 
            // easyDiffButton
            // 
            this.easyDiffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyDiffButton.Location = new System.Drawing.Point(104, 125);
            this.easyDiffButton.Margin = new System.Windows.Forms.Padding(5);
            this.easyDiffButton.Name = "easyDiffButton";
            this.easyDiffButton.Size = new System.Drawing.Size(141, 42);
            this.easyDiffButton.TabIndex = 0;
            this.easyDiffButton.Text = "Легка важкість";
            this.easyDiffButton.UseVisualStyleBackColor = true;
            this.easyDiffButton.Click += new System.EventHandler(this.easyDiffButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Очки:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Час:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Canvas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GameForm";
            this.Text = "Вдар крота!";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Canvas.ResumeLayout(false);
            this.Canvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private Button easyDiffButton;
        private Button hardDiffButton;
        private Button middleDiffButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}