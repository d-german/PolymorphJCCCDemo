using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalHealthcareViewer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var viewer = new UniversalViewer(DataSourceFactory.BuildDataSource(0));
            viewer.DrawPage(1);
        }
    }
}
