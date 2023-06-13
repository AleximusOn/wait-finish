using System.Threading.Tasks;

namespace WaitFinish.Common
{
	public class TestedClass
	{
		private const int _defaultDelay = 200;
		public async Task DoSomething(int? delay)
		{
			var _delay = !delay.HasValue || delay < 0 ? _defaultDelay : delay.Value;

			await Task.Delay(_delay);
		}
	}
}
