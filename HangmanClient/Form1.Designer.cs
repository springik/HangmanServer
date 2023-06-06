namespace HangmanClient
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
            btn_disconnect = new Button();
            btn_connect = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_disconnect
            // 
            btn_disconnect.Location = new Point(12, 409);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(94, 29);
            btn_disconnect.TabIndex = 0;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = true;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(12, 374);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(94, 29);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(114, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(560, 193);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btn_connect);
            Controls.Add(btn_disconnect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_disconnect;
        private Button btn_connect;
        private RichTextBox richTextBox1;
    }
}