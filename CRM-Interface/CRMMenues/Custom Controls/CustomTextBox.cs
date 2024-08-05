using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Deployment.Application;

namespace CRM_Interface.Custom_Controls
{
    [DefaultEvent("_TextChanged") ]
    public partial class CustomTextBox : UserControl
    {
        //properties
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color foreColor = Color.White;
        private Color backColor = Color.LightCyan;
        private Font font;
        private Color focusColor = Color.Red;
        private bool focused = false;
        
        public Color borderColor1
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int borderSize1 
        {
            get 
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool Underlined
        { 
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public Color ForeColor1
        {
            get
            {
                return foreColor;
            }
            set
            {
                foreColor = value;
                txt.ForeColor = value;
            }
        }

        public Color BackColor1
        { 
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                txt.BackColor = value;
            }
        }

        public Font font1
        { 
            get 
            {
                return font;
            }
            set
            {
                font = value;
                txt.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string texts1
        { 
            get
            {
                return txt.Text;
            }
            set
            {
                txt.Text = value;
            }
        }
        
        public Color FocusColor
        {
            get
            {
                return focusColor; 
            }
            set
            {
                focusColor = value;
            }
        }


        //events
        public event EventHandler _TextChanged; 
        public CustomTextBox()
        {
            InitializeComponent();
        }

        //overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            { 
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!focused)
                {
                    if (underlinedStyle) // Underline type
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawLine(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = focusColor;
                    if (underlinedStyle) // Underline type
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawLine(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
               
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) 
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (txt.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txt.Multiline = true;
                txt.MinimumSize = new Size(0, txtHeight);
                txt.Multiline = false;

                this.Height = txt.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            focused = false;
            this.Invalidate();
        }
    }
}
