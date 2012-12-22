using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MinecraftLauncher.UI
{
	/// <summary>
	/// Представляет элемент управления для просмотра скинов Minecraft.
	/// </summary>
	class SkinViewer : Control
	{
		private Image skin;
		private bool frontRender = true;
		private float scaleFactor = 8;

		/// <summary>
		/// Графический файл скина. (64х32)
		/// </summary>
		public Image Skin
		{
			get { return skin; }
			set
			{
				skin = value;
				Initialize();
				Invalidate();
			}
		}

		/// <summary>
		/// Коэффициент масштабирования.
		/// </summary>
		public Single ScaleFactor
		{
			get { return scaleFactor; }
			set
			{
				scaleFactor = value;
				Invalidate();
			}
		}

		/// <summary>
		/// Отображать переднюю или заднюю часть скина.
		/// </summary>
		public Boolean FrontRender
		{
			get { return frontRender; }
			set
			{
				frontRender = value;
				Invalidate();
			}
		}

		private Image HeadFront { get; set; }
		private Image HeadBack { get; set; }
		private Image ArmLeftFront { get; set; }
		private Image ArmLeftBack { get; set; }
		private Image ArmRightFront { get; set; }
		private Image ArmRightBack { get; set; }
		private Image ChestFront { get; set; }
		private Image ChestBack { get; set; }
		private Image LegLeftFront { get; set; }
		private Image LegLeftBack { get; set; }
		private Image LegRightFront { get; set; }
		private Image LegRightBack { get; set; }

		/// <summary>
		/// Базовая инициализация.
		/// </summary>
		public SkinViewer()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
		}

		/// <summary>
		/// Подготавливает скин для отображения. Нарезает на кусочки.
		/// </summary>
		private void Initialize()
		{
			if (skin == null)
				return;

			// Голова
			HeadFront = CropImage(skin, new Rectangle(8, 8, 8, 8));
			HeadBack = CropImage(skin, new Rectangle(24, 8, 8, 8));

			// Руки - перед
			ArmRightFront = CropImage(skin, new Rectangle(44, 20, 4, 12));
			ArmLeftFront = CropImage(skin, new Rectangle(44, 20, 4, 12));
			ArmLeftFront.RotateFlip(RotateFlipType.RotateNoneFlipX);

			// Руки - зад
			ArmRightBack = CropImage(skin, new Rectangle(52, 20, 4, 12));
			ArmLeftBack = CropImage(skin, new Rectangle(52, 20, 4, 12));
			ArmLeftBack.RotateFlip(RotateFlipType.RotateNoneFlipX);

			// Грудь
			ChestFront = CropImage(skin, new Rectangle(20, 20, 8, 12));
			ChestBack = CropImage(skin, new Rectangle(32, 20, 8, 12));

			// Ноги - перед
			LegRightFront = CropImage(skin, new Rectangle(4, 20, 4, 12));
			LegLeftFront = CropImage(skin, new Rectangle(4, 20, 4, 12));
			LegLeftFront.RotateFlip(RotateFlipType.RotateNoneFlipX);

			// Ноги - зад
			LegRightBack = CropImage(skin, new Rectangle(12, 20, 4, 12));
			LegLeftBack = CropImage(skin, new Rectangle(12, 20, 4, 12));
			LegLeftBack.RotateFlip(RotateFlipType.RotateNoneFlipX);
		}

		/// <summary>
		/// Вырезает и возвращает кусок изображения.
		/// </summary>
		/// <param name="srcImage">Исходное изображение</param>
		/// <param name="cropArea">Область для вырезки</param>
		/// <returns></returns>
		private Image CropImage(Image srcImage, Rectangle cropArea)
		{
			var rtnImage = new Bitmap(cropArea.Width, cropArea.Height);

			using (var gfx = Graphics.FromImage(rtnImage))
			{
				gfx.DrawImage(srcImage, 0, 0, cropArea, GraphicsUnit.Pixel);
			}

			return rtnImage;
		}

		/// <summary>
		/// Рисует часть скина.
		/// </summary>
		/// <param name="gfx">GDI+ drawing surface</param>
		/// <param name="image">Изображение</param>
		/// <param name="x">X-координата</param>
		/// <param name="y">У-координата</param>
		private void DrawPart(Graphics gfx, Image image, int x, int y)
		{
			if (image == null)
				return;

			gfx.DrawImage(image, x + 1, y, image.Width, image.Height);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Skin == null)
				return;

			using (var image = new Bitmap(17, 32))
			{
				using (var gfx = Graphics.FromImage(image))
				{
					DrawPart(gfx, frontRender ? HeadFront : HeadBack, 4, 0);
					DrawPart(gfx, frontRender ? ArmRightFront : ArmRightBack, 0, 8);
					DrawPart(gfx, frontRender ? ArmLeftFront : ArmLeftBack, 12, 8);
					DrawPart(gfx, frontRender ? ChestFront : ChestBack, 4, 8);
					DrawPart(gfx, frontRender ? LegRightFront : LegRightBack, 4, 20);
					DrawPart(gfx, frontRender ? LegLeftFront : LegLeftBack, 8, 20);
				}

				e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

				var cx = (ClientRectangle.Width / 2f);
				var cy = (ClientRectangle.Height / 2f);

				var transform = new Matrix();
				transform.Translate(cx, cy);
				transform.Scale(scaleFactor, scaleFactor);
				transform.Translate(-cx - image.Width / 2f, -cy - image.Height / 2f);

				e.Graphics.Transform = transform;
				e.Graphics.DrawImage(image, cx, cy);
			}

			base.OnPaint(e);
		}
	}
}
