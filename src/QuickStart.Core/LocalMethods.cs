using APISurface;
using System.Threading.Tasks;

namespace QuickStart.Core
{
	public class LocalMethods
    {
		public async Task<object> UseComposedAssembly( dynamic input )
		{
			return new MessageManager().SendMessage();
		}
    }
}
