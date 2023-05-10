using iTextSharp.text;

namespace Essai.Classes
{
    internal class RectangleWithBackground : iTextSharp.text.Rectangle
    {
        public BaseColor BackgroundColor { get; set; }

        public RectangleWithBackground(float width, float height) : base(width, height)
        {
        }

        public RectangleWithBackground(float llx, float lly, float urx, float ury) : base(llx, lly, urx, ury)
        {
        }

        public RectangleWithBackground(iTextSharp.text.Rectangle rect) : base(rect)
        {
        }

        public RectangleWithBackground(float llx, float lly, float urx, float ury, int rotation) : base(llx, lly, urx, ury, rotation)
        {
        }

        public RectangleWithBackground(float llx, float lly, float urx, float ury, int rotation, int border) : base(llx, lly, urx, ury)
        {
            this.Rotation = rotation;
            this.Border = border;
        }

        public RectangleWithBackground(float llx, float lly, float urx, float ury, int rotation, int border, BaseColor borderColor, BaseColor backgroundColor) : base(llx, lly, urx, ury)
        {
            this.Rotation = rotation;
            this.Border = border;
            this.BorderColor = borderColor;
            this.BackgroundColor = backgroundColor;
        }
    }
}