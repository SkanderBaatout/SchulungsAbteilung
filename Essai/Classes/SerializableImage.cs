using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Essai.Classes
{
    [Serializable]
    public class SerializableImage : ISerializable
    {
        private Image image;

        public SerializableImage() { }

        public SerializableImage(Image image)
        {
            this.image = image;
        }

        protected SerializableImage(SerializationInfo info, StreamingContext context)
        {
            byte[] data = (byte[])info.GetValue("ImageData", typeof(byte[]));
            using (MemoryStream ms = new MemoryStream(data))
            {
                this.image = Image.FromStream(ms);
            }
        }

        public Image GetImage(int width, int height)
        {
            return this.image.GetThumbnailImage(width, height, null, IntPtr.Zero);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                this.image.Save(ms, ImageFormat.Png);
                byte[] data = ms.ToArray();
                info.AddValue("ImageData", data);
            }
        }
    }
}
