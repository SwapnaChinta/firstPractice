using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EaFramework.Driver.DriverFixture;


namespace EaFramework.Config
{
    public class TestSettings
    {
        //this class has only declarations of the properties

        public BrowserType BrowserType { get; set; }

        public Uri? ApplicationUrl { get; set; }

       
    }
}
