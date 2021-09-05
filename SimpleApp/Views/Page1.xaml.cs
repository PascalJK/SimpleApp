using SkiaSharp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        SKPaint blackFillPaint = new()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.Black
        };

        SKPaint whiteStrokePaint = new()
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColors.White,
            StrokeWidth = 2,
            StrokeCap = SKStrokeCap.Round,
            IsAntialias = true,
        };

        SKPaint whiteFillPaint = new()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.White
        };

        SKPaint grayFillPaint = new()
        {
            Style = SKPaintStyle.Fill,
            Color = SKColors.Gray
        };

        public Page1()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                canvasview.InvalidateSurface();
                return true;
            });
        }

        private void Canvasview_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.CornflowerBlue);

            // get surface info
            var width = e.Info.Width;
            var height = e.Info.Height;

            //Set transform
            canvas.Translate(width / 2, height / 2);
            canvas.Scale(width / 200f);

            // Get DateTime
            DateTime date = DateTime.Now;
            dateLabel.Text = $"{date:HH:mm:ss}";

            // Clock background
            canvas.DrawCircle(0, 0, 100, blackFillPaint);

            // Hour + min marks
            for (int angle = 0; angle < 360; angle += 6)
            {
                canvas.DrawCircle(0, -90, angle % 30 == 0 ? 4 : 2, whiteFillPaint);
                canvas.RotateDegrees(6);
            }

            // Hour hand
            canvas.Save();
            canvas.RotateDegrees(30 * date.Hour + date.Minute / 2f);
            whiteStrokePaint.StrokeWidth = 15;
            canvas.DrawLine(0, 0, 0, -50, whiteStrokePaint);
            canvas.Restore();

            // Minute hand
            canvas.Save();
            canvas.RotateDegrees(6 * date.Minute + date.Second / 10f);
            whiteStrokePaint.StrokeWidth = 10;
            canvas.DrawLine(0, 0, 0, -70, whiteStrokePaint);
            canvas.Restore();
            canvas.Restore();

            // Second hand
            canvas.Save();
            float seconds = date.Second + date.Millisecond / 1000f;
            canvas.RotateDegrees(6 * seconds);
            whiteStrokePaint.StrokeWidth = 5;
            canvas.DrawLine(0, 10, 0, -80, whiteStrokePaint);
            canvas.Restore();
        }
    }
}