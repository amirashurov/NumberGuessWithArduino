using System;
using System.IO.Ports;
using System.Threading;

namespace NumberGuess
{
	class ButtonListener
	{
		readonly SerialPort _serialPort;
		private readonly int _baudRate = 9600;

		private Boolean _hasNew = false;

		private string _lastLine;
		private bool _readNewLine = false;

		public String LastLine
		{
			get { return _lastLine; }
			//private set { _lastLine = value; }
		}

		public ButtonListener(String name)
		{
			_baudRate = 9600;
			_serialPort = new SerialPort(name, _baudRate);
			_serialPort.Open();
			Thread t = new Thread(Reading)
			{
				IsBackground = true
			};
			t.Start();

		}

		private void Reading()
		{

			var tempLine = "";
			while (true)
			{

				if (_serialPort.BytesToRead > 0)
				{
					tempLine = _serialPort.ReadLine();
					if (_readNewLine)
					{
						_lastLine = tempLine;
						_hasNew = true;
						_readNewLine = false;
					}
				}
				if (!String.IsNullOrEmpty(tempLine))
				{
					_lastLine = tempLine;

				}
			}

		}

		public String ReadLine()
		{
			_readNewLine = true;
			_hasNew = false;
			while (true)
			{
				if (_hasNew)
				{
					return _lastLine; 
				}
			}
		}


	}
}