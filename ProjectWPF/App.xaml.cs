using Project.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var locationManager = new LocationManager();
            var test = locationManager.GetLocations();
            foreach(var location in test)
            {
                Console.Write(location.Name);
            }
        }
    }
}
