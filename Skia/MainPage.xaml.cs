using System;
using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace Skia
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			Title = "Simple Circle";

			InitializeComponent();
		}

		SKPaint paint = new SKPaint
		{
			Style = SKPaintStyle.Stroke,
			Color = Color.Blue.ToSKColor(),
			StrokeWidth = 5
		};

		SKPaint textPaint = new SKPaint
		{
			Color = SKColors.Blue,
			TextSize = 24,
			TextAlign = SKTextAlign.Center
		};

		SKPaint paint_Black = new SKPaint
		{
			Style = SKPaintStyle.Stroke,
			Color = Color.Black.ToSKColor(),
			StrokeWidth = 5
		};

		void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
		{
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear();

			var canvasWidht = args.Info.Width;
			var canvasHeight = args.Info.Height;

			canvas.DrawLine(40, 40, 40, canvasHeight - 40, paint);
			canvas.DrawLine(40, canvasHeight - 40, canvasWidht - 40, canvasHeight - 40, paint);
			float x = 40;
			float y = 40;
			float del_x = (canvasWidht - 40) / 8;
			float del_y = (canvasHeight - 40) / 8;


			for (int i=0; i<7; i++)
			{
				x += del_x;
				y += del_y;
				canvas.DrawText("12.05", x, canvasHeight, textPaint);
				canvas.DrawLine(x, 0, x, canvasHeight - 40, paint_Black);
			}

		}

		private void canvasView_1_PaintSurface(object sender, SKPaintSurfaceEventArgs args)
		{
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			canvas.Clear();

			var canvasWidht = args.Info.Width;
			var canvasHeight = args.Info.Height;

			canvas.DrawLine(40, 40, 40, canvasHeight - 40, paint);
			canvas.DrawLine(40, canvasHeight - 40, canvasWidht - 40, canvasHeight - 40, paint);
			float x = 20;
			float del = (canvasWidht - 20) / 8;

			for (int i = 0; i < 7; i++)
			{
				x += del;
				canvas.DrawText("12.05", x, canvasHeight, textPaint);
			}
		}
	}
}
