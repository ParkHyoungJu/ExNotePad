using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExNotePad
{
    class CustomMessageBox:System.Windows.Forms.Form
    {
        private static CustomMessageBox messageBox;

        private Label message = new Label();
        private Button b1 = new Button();
        private Button b2 = new Button();
        private Button b3 = new Button();

        public CustomMessageBox(string titleMessage) {}

        private CustomMessageBox(string title, string body, string button1, string button2, string button3)
        {
            this.ClientSize = new System.Drawing.Size(490, 150);
            this.Text = title;

            b3.Location = new System.Drawing.Point(411, 112);
            b3.Size = new System.Drawing.Size(75, 23);
            b3.Text = button3;
            b3.BackColor = Control.DefaultBackColor;
            b3.Click += new EventHandler(delegate(object sender, EventArgs e) {
                CloseBox();
            });

            b2.Location = new System.Drawing.Point(315, 112);
            b2.Size = new System.Drawing.Size(91, 23);
            b2.Text = button2;
            b2.BackColor = Control.DefaultBackColor;
            b2.DialogResult = DialogResult.No;

            b1.Location = new System.Drawing.Point(235, 112);
            b1.Size = new System.Drawing.Size(75, 23);
            b1.Text = button1;
            b1.BackColor = Control.DefaultBackColor;
            b1.DialogResult = DialogResult.Yes;

            message.Location = new System.Drawing.Point(10, 10);
            message.Text = body;
            message.Font = Control.DefaultFont;
            message.AutoSize = true;

            this.BackColor = Color.White;
            this.ShowIcon = false;

            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(message);
        }

        public static DialogResult ShowBox(string title, string body, string button1, string button2, string button3)
        {
            messageBox = new CustomMessageBox(title, body, button1, button2, button3);
            messageBox.StartPosition = FormStartPosition.CenterParent;

            return messageBox.ShowDialog();
        }

        public static void CloseBox()
        {
            if (messageBox != null) messageBox.Close();
        }
    }
}
