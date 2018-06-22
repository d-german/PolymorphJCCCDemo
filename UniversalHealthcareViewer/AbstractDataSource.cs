using System;
using System.Drawing;
using System.Windows.Forms;

namespace UniversalHealthcareViewer
{
    public abstract class AbstractDataSource
    {
        //DIP
        public string DocumentId { get; set; }
        public DateTime CreationDate { get; set; }

        public abstract Image GetPage(int pageNum);
    }


    public class LocalDataSource : AbstractDataSource
    {
        public override Image GetPage(int pageNum)
        {
            string filename;
            using (var openFileDialog = new OpenFileDialog())
            {
                filename = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog.FileName;
                }
            }

            return Image.FromFile(filename);
        }
    }

    public class RemoteDataSource : AbstractDataSource
    {
        public override Image GetPage(int pageNum)
        {
            return Image.FromFile($"http://imageService/{pageNum}");
        }
    }
}