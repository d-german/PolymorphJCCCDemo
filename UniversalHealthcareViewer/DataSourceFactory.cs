using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalHealthcareViewer
{
    public class DataSourceFactory
    {
        public static AbstractDataSource BuildDataSource(int documentId)
        {
            return documentId == 0 ?  new LocalDataSource(55) as AbstractDataSource : new RemoteDataSource(documentId);
        }
    }
}
