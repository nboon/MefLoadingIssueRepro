using System;
using System.Composition.Hosting;
using System.IO;
using System.Runtime.Loader;

namespace APISurface
{
	public class MessageManager
    {
		public string SendMessage()
		{
			var configuration = new ContainerConfiguration();
			
			var path = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, @"APIImplementations.dll" );
			var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath( path );
			configuration.WithAssembly( assembly );
			var host = configuration.CreateContainer();
			var messageSender = host.GetExport<IMessageSender>( "IMessageSender" );

			return messageSender.SendMessage();
		}
	}
}
