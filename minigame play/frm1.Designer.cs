namespace minigame_play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            logo = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.Location = new Point(282, 222);
            button1.Name = "button1";
            button1.Size = new Size(185, 185);
            button1.TabIndex = 0;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(544, 222);
            button2.Name = "button2";
            button2.Size = new Size(185, 185);
            button2.TabIndex = 1;
            button2.Text = "settings";
            button2.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.Menu;
            logo.ForeColor = SystemColors.Menu;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-1, 1);
            logo.Name = "logo";
            logo.Size = new Size(800, 195);
            logo.TabIndex = 2;
            logo.UseVisualStyleBackColor = false;
            logo.Click += logo_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 222);
            button3.Name = "button3";
            button3.Size = new Size(185, 185);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(logo);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minigame play";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button logo;
        private Button button3;
    }
}
