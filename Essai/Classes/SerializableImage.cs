using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;

namespace Essai.Classes
{
    [Serializable]
    public class SerializableImage
    {
        private Image _image;

        public SerializableImage(Image image)
        {
            _image = image;
        }

        public Image GetImage(int width, int height)
        {
            if (_image == null)
            {
                return null;
            }

            return _image.GetThumbnailImage(width, height, null, IntPtr.Zero);
        }

        public static implicit operator Image(SerializableImage si)
        {
            return si._image;
        }

        public static implicit operator SerializableImage(Image i)
        {
            return new SerializableImage(i);
        }

        public static implicit operator byte[](SerializableImage si)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                si._image.Save(ms, si._image.RawFormat);
                return ms.ToArray();
            }
        }

        public static implicit operator SerializableImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new SerializableImage(Image.FromStream(ms));
            }
        }
    }
}