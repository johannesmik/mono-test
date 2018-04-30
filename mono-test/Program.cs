using System;
using System.Threading.Tasks;
using System.Threading;

namespace monotest
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			KafkaReceiver kafkareceiver = new KafkaReceiver ();
		
			Logic logic = new Logic (kafkareceiver);

			while (true) {
				Thread.Sleep (500);
				Console.WriteLine ("Hello World!");
			}
		}

	}
}
