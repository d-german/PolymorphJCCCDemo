namespace UniversalHealthcareViewer
{
    public class DataSourceFactory
    {
        public static AbstractDataSource BuildDataSource(int documentId)
        {
            AbstractDataSource dataSource = null;
            
            switch (documentId)
            {
                case 0:
                    dataSource = new LocalDataSource(); 
                    break;
                case 1:
                   dataSource = new RemoteDataSource(); 
                    break;
            }

            return dataSource;
        }
    }
}
