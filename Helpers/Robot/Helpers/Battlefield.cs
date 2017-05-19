    using Santom;

namespace Tomtom.Utility
{
    public class Battlefield
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double EffectiveWidth { get; set; }
        public double EffectiveHeight { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Top { get; set; }
        public double Bottom { get; set; }
//        public Point2D TopLeft => new Point2D(Left, Top);             //NOTE: We'd use lambda, but the compiler we use doesn't recognize it.
//        public Point2D TopRight => new Point2D(Right, Top);
//        public Point2D BottomLeft => new Point2D(Left, Bottom);
//        public Point2D BottomRight => new Point2D(Right, Bottom);
        public Point2D TopLeft{
            get { return new Point2D(Left, Top); }
        }
        public Point2D TopRight {
            get { return new Point2D(Right, Top); }
        }
        public Point2D BottomLeft {
            get { return new Point2D(Left, Bottom); }
        }
        public Point2D BottomRight {
            get { return new Point2D(Right, Bottom); }
        }

        public Battlefield(double width, double height, double robotRadius)
        {
            Width = width;
            Height = height;
            Top = height - robotRadius;
            Bottom = robotRadius;
            Right = width - robotRadius;
            Left = robotRadius;
            EffectiveWidth = Right - Left;
            EffectiveHeight = Top - Bottom;
        }
    }
}