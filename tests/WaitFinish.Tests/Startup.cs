using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WaitFinish.Tests
{
    [SetUpFixture]
    public class Startup
    {
        private string _listenedFile;
        private string _waitingText = "IS_FINISH";

        [OneTimeSetUp]
        public void Setup()
        {
            _listenedFile = System.Environment.GetEnvironmentVariable("FINISH_TEST_FILE");
            var waitingText = System.Environment.GetEnvironmentVariable("FINISH_TEST_MESSAGE");
            if (waitingText != null)
            {
                _waitingText = waitingText;
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (_listenedFile != null)
            {
                System.IO.File.WriteAllText(_listenedFile, _waitingText);
            }
        }
    }
}