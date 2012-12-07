using System;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftLauncher.UI
{
    public class ImageButton : Button
    {
		public enum ImageButtonState
		{
			Normal, Active, Hover, Disabled
		}

	    private StringFormat stringFormat = new StringFormat
	    {
		    Alignment = StringAlignment.Center,
		    LineAlignment = StringAlignment.Center
	    };

		private ImageButtonState state = ImageButtonState.Normal;

        public Image Normal { get; set; }
        public Image Active { get; set; }
	    public Image Hover { get; set; }
	    public Image Disabled { get; set; }

	    public ImageButtonState State
	    {
		    get { return state; }
		    set
		    {
			    state = value;
			    Enabled = state != ImageButtonState.Disabled;
			    Invalidate();
		    }
	    }

	    public ImageButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
	        if (!Enabled)
		        return;

	        state = ImageButtonState.Active;
	        Invalidate();
	        base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
			if (!Enabled)
				return;

			state = ImageButtonState.Normal;
            Invalidate();
            base.OnMouseUp(e);
        }

		protected override void OnMouseEnter(EventArgs e)
		{
			if (!Enabled)
				return;

			state = ImageButtonState.Hover;
			Invalidate();
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			if (!Enabled)
				return;

			state = ImageButtonState.Normal;
			Invalidate();
			base.OnMouseLeave(e);
		}

        protected override void OnPaint(PaintEventArgs e)
        {
	        OnPaintBackground(e);

			switch (state)
            {
                case ImageButtonState.Normal:
                    if (Normal != null)
                        e.Graphics.DrawImage(Normal, ClientRectangle);
                    break;
                case ImageButtonState.Active:
                    if (Active != null)
						e.Graphics.DrawImage(Active, ClientRectangle);
                    break;
                case ImageButtonState.Hover:
					if (Hover != null)
						e.Graphics.DrawImage(Hover, ClientRectangle);
                    break;
                case ImageButtonState.Disabled:
		            if (Disabled != null)
						e.Graphics.DrawImage(Disabled, ClientRectangle);
                    break;
            }

	        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
        }
    }
}

