using System.Drawing;
using System.Windows.Forms;

namespace UniversalHealthcareViewer
{
    public abstract class AbstractDataSource
    {
        protected AbstractDataSource(int documentId)
        {
            DocumentId = documentId;
        }
        //DIP
        public int DocumentId { get; set; }

        public abstract Image GetPage(int pageNum);

        public virtual int GetPageCount()
        {
            return 1;
        }
    }

    public class LocalDataSource : AbstractDataSource
    {
        public LocalDataSource(int documentId) : base(documentId) //reuse
        {
        }

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
        public RemoteDataSource(int documentId) : base(documentId)
        {
        }

        public override Image GetPage(int pageNum)
        {
            return Image.FromFile($"http://imageService/{DocumentId}/{pageNum}");
        }

        public override int GetPageCount()
        {
            return base.GetPageCount() + 1;
        }
    }
}