using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NTDLS.Editors.Autolist
{
    public partial class TipForm : Form
    {
        public string TipText
        {
            get { return this._Text.Text; }
            set {
                string text = value;

                System.Drawing.SizeF textSize = CreateGraphics().MeasureString(text, Font);

                int maxWidth = 500;
                if (textSize.Width > maxWidth)
                {
                    textSize.Width = maxWidth;
                    textSize.Height = textSize.Height * ((textSize.Width / maxWidth) + 1);
                }

                this.Size = new System.Drawing.Size((int)textSize.Width, (int)textSize.Height);

                this._Text.Text = text;
            }
        }

        public TipForm()
        {
            InitializeComponent();

            this.SuspendLayout();

            //this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TipForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout();
        }
    }
}
