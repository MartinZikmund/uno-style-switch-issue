using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoStyleSwitchIssue.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoStyleSwitchIssue.App(), args);
            host.Run();
        }
    }
}
