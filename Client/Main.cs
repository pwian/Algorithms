using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client
{
	public class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			var binding = new BasicHttpBinding();
			var endPoint = new EndpointAddress("http://localhost/Algorithms");
			var channelFactory = new ChannelFactory<IService>(binding, endPoint);
			Api.Service = channelFactory.CreateChannel();

			Api.Service.GetData(1);
			Api.Service.SendAlgorithm("stop");

			var app = new Application { MainWindow = new MainWindow() };
			app.Run(app.MainWindow);
		}
	}
}
