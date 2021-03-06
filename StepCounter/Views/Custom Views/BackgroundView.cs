﻿using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;
using MonoTouch.CoreGraphics;
using System.ComponentModel;

namespace StepCounter
{
    [Register("BackgroundView"), DesignTimeVisible(true)]
    public class BackgroundView : UIView
    {
        #region constructor
        public BackgroundView ()
        {
        }

        public BackgroundView (IntPtr handle) : base (handle)
        {
            Initialize ();
        }

        private void Initialize ()
        {
        }
        #endregion

        //Generated with PaintCode 2.2
        public override void Draw(System.Drawing.RectangleF rect)
        {
            base.Draw(rect);

            // General Declarations
            var colorSpace = CGColorSpace.CreateDeviceRGB();
            var context = UIGraphics.GetCurrentContext();

            // Color Declarations
            var darkBlue = UIColor.FromRGBA(0.053f, 0.123f, 0.198f, 1.000f);
            var lightBlue = UIColor.FromRGBA(0.191f, 0.619f, 0.845f, 1.000f);

            // Gradient Declarations
            var backgroundGradientColors = new CGColor [] {lightBlue.CGColor, darkBlue.CGColor};
            var backgroundGradientLocations = new float [] {0.0f, 1.0f};
            var backgroundGradient = new CGGradient(colorSpace, backgroundGradientColors, backgroundGradientLocations);

            // Rectangle Drawing
            RectangleF rectangleRect = new RectangleF(rect.GetMinX() + (float)Math.Floor(rect.Width * -0.12917f + 0.5f), rect.GetMinY() + (float)Math.Floor(rect.Height * 0.00000f + 0.5f), (float)Math.Floor(rect.Width * 1.00000f + 0.5f) - (float)Math.Floor(rect.Width * -0.12917f + 0.5f), (float)Math.Floor(rect.Height * 1.00000f + 0.5f) - (float)Math.Floor(rect.Height * 0.00000f + 0.5f));
            var rectanglePath = UIBezierPath.FromRect(rectangleRect);
            context.SaveState();
            rectanglePath.AddClip();
            context.DrawLinearGradient(backgroundGradient,
                new PointF(rectangleRect.GetMidX(), rectangleRect.GetMinY()),
                new PointF(rectangleRect.GetMidX(), rectangleRect.GetMaxY()),
                0);
            context.RestoreState();
        }
    }
}

