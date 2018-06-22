using System;

namespace UniversalHealthcareViewer
{
    public class UniversalViewer
    {
        //DIP
        public AbstractDataSource DataSource { get; set; }
        
        public UniversalViewer(AbstractDataSource dataSource)
        {
            this.DataSource = dataSource;
        }
        //OCP,LSP,DIP 
        public void DrawPage(int pageNum)
        {
            var image = DataSource.GetPage(pageNum);
            Console.WriteLine($"Using {DataSource.ToString()} to draw a page with size {image.Size}");
        }
    }
}
