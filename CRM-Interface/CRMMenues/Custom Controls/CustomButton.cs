using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace CRM_Interface.Custom_Controls
{
    public class CustomButton : Button
    {
        //Fields
        private int BorderSize = 0;
        private int BorderRadius = 40;
        private Color BorderColor = Color.PaleVioletRed;
        private Color BackgroundColor = Color.BlueViolet;
        private Color ForeColors = Color.Magenta ;

        public int BorderSize1 
        {
            get 
            { 
                return BorderSize; 
            }
            set 
            { 
                BorderSize = value;
                this.Invalidate();
            }
        }
        public int BorderRadius1 
        {
            get 
            { 
                return BorderRadius; 
            }
            set 
            {
                BorderRadius = value;
                this.Invalidate();
            }
        
        }
        public Color BorderColor1 
        {
            get 
            { 
                return BorderColor; 
            }

            set 
            {
                BorderColor = value;
                this.Invalidate();
            }
        }
        public Color BackgroundColor1
        { 
            get 
            {
                return BackgroundColor;
            }
            set 
            {
                BackgroundColor = value;
                this.Invalidate ();
            } 
        }

        public Color ForeColor1
        {
            get 
            {
                return ForeColor; 
            }
            set 
            {
                ForeColor = value; 
                this.Invalidate ();
            }
        
        }


        //Consctructor
        public CustomButton ()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size (150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }


        //methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        { 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height -radius, radius, radius, 90, 90);

            return path;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBroder = new RectangleF(1,1,this.Width - 0.8F, this.Height - 1);

            if (BorderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBroder, BorderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                { 
                
                    penBorder.Alignment = PenAlignment.Inset;
                    //button surface
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // draw control border
                    if (BorderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }

            else //normal button
            {
                //button surface
                this.Region = new Region(rectSurface);

                //button border
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }


            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackcolorChanged);

        }

        private void Container_BackcolorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
