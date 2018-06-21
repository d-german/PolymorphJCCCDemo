﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalHealthcareViewer
{
    public class UniversalViewer
    {
        public AbstractDataSource DataSource { get; set; }

        public UniversalViewer(AbstractDataSource dataSource)
        {
            this.DataSource = dataSource;
        }

        public void DrawPage(int pageNum)
        {
            var image = DataSource.GetPage(pageNum);
            Console.WriteLine($"Using {DataSource.ToString()} to draw a page.");
        }
    }
}