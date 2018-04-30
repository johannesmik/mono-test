using System;
using System.Threading;
using System.Threading.Tasks;

namespace monotest
{
	public class Logic
	{

		private KafkaReceiver _kafkareceiver;

		public Logic (KafkaReceiver kafkareceiver)
		{
			_kafkareceiver = kafkareceiver;

			Task mytask = Task.Run (() => {
				_kafkareceiver.receive (on_message_receive);
			});
		}

		public void on_message_receive(string msg) {
			Thread.Sleep (1500);
			Console.WriteLine ($"Received message: {msg}");
			// Do some Logic with received message
		}

	}
}

