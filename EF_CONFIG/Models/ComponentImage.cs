using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CONFIG.Models
{
    public class ComponentImage
    {
        public ComponentImage(Image img)
        {
            SetImage(img);
        }

        public ComponentImage() { }

        [Key]
        public int Id { get; set; }
        public string ImageName { get; set; } //Image path
        public int? MachineComponentId { get; set; }
        public string ImageString { get; set; }

        [NotMapped]
        public Image Image
        {
            get
            {
                return StringToImage(ImageString);
            }
        }

        public void SetImage(Image img)
        {
            ImageString = ImageToString(img);
        }

        public string ImageToString(Image image)
        {
            try
            {
                if (image == null)
                    return null;

                MemoryStream ms = new MemoryStream();

                try
                {
                    image.Save(ms, image.RawFormat);
                }
                catch
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                byte[] array = ms.ToArray();

                return Convert.ToBase64String(array);
            }
            catch (Exception ex)
            { return null; }
        }

        public Image StringToImage(string imageString)
        {
            try
            {
                if (imageString == null)
                    return null;

                byte[] array = Convert.FromBase64String(imageString);

                Image image = Image.FromStream(new MemoryStream(array));

                return image;
            }
            catch { return null; }
        }

        public virtual MachineComponent MachineComponent { get; set; }
    }
}
