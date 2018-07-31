using System.Composition;
using APISurface;

namespace APIImplimentations
{
	[Export( "IMessageSender", typeof( IMessageSender ) )]
	public class MessageSender : IMessageSender
	{
		public string SendMessage()
		{
			return "Message sent successfully.";
		}
	}
}
