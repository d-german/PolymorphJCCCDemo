using System;

namespace UniversalHealthcareViewer
{
    public class UniversalViewer
    {
        //DI
        public AbstractDataSource DataSource { get; set; }
        //DIP
        public UniversalViewer(AbstractDataSource dataSource)
        {
            this.DataSource = dataSource;
        }
        //OCP?
        public void DrawPage(int pageNum)
        {
            var image = DataSource.GetPage(pageNum);
            Console.WriteLine($"Using {DataSource.ToString()} to draw a page.");
        }
    }
}
