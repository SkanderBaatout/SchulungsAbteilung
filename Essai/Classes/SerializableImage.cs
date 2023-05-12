using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;

namespace Essai.Classes
{
    [Serializable]
    public class SerializableImage : ISerializable
    {
        private Image _image;

        public SerializableImage() { }

        public SerializableImage(Image image)
        {
            _image = image;
        }

        protected SerializableImage(SerializationInfo info, StreamingContext context)
        {
            byte[] data = (byte[])info.GetValue("PhotoData", typeof(byte[]));
            if (data != null && data.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    try
                    {
                        _image = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        // Log the error or display an error message
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        public Image GetImage(int width, int height)
        {
            if (_image == null)
            {
                return null;
            }

            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Invalid width or height value");
            }

            try
            {
                return _image.GetThumbnailImage(width, height, null, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                // Log the error or display an error message
                Console.WriteLine("Error getting thumbnail image: " + ex.Message);
                return null;
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (_image == null)
            {
                return;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                _image.Save(ms, ImageFormat.Png);
                byte[] data = ms.ToArray();
                info.AddValue("PhotoData", data, typeof(byte[]));
            }
        }
    }
}