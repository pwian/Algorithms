using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	[ServiceContract]
	interface IService
	{
		[OperationContract]
		void SendAlgorithm(string text);

		[OperationContract]
		string GetData(int value);
	}
}
