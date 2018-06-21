using System;

namespace UniversalHealthcareViewer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            const int documentId = 0;
            var viewer = new UniversalViewer(DataSourceFactory.BuildDataSource(documentId));
            viewer.DrawPage(1);
        }
    }
}
