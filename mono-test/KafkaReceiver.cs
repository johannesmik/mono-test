using System;
using System.Threading;

namespace monotest
{
	public class KafkaReceiver
	{
		public KafkaReceiver (){}

		public void receive (Action<string> callback) {

			int i = 0;

			while (true) {
				Thread.Sleep (200);
				i += 1;
				Console.WriteLine ($"Sending message nr {i}");
				callback ($"message nr {i}");
			}

		}
	}
}

