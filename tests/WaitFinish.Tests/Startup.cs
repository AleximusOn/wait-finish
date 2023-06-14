using System;
using System.IO;
using NUnit.Framework;

namespace WaitFinish.Tests
{
	[SetUpFixture]
	public class Startup
	{
		private const string _testDoneFileName = "TEST_IS_DONE.txt";
		private const string _waitingText = "DONE";

		private string _resultFile;

		[OneTimeSetUp]
		public void Setup()
		{
			var testDoneFilePath = Environment.GetEnvironmentVariable("TEST_DONE_FILE_PATH");
			if (_testDoneFileName != null)
			{
				if (!Directory.Exists(testDoneFilePath))
				{
					Directory.CreateDirectory(testDoneFilePath);
				}

				_resultFile = Path.Combine(testDoneFilePath, _testDoneFileName);
				if (File.Exists(_resultFile))
				{
					File.Delete(_resultFile);
				}
			}
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			if (_resultFile != null)
			{
				File.WriteAllText(_resultFile, _waitingText);
			}
		}
	}
}