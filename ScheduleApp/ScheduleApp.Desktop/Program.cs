using osu.Framework.Platform;
using osu.Framework;
using ScheduleApp.Game;

namespace ScheduleApp.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"ScheduleApp"))
            using (osu.Framework.Game game = new ScheduleAppGame())
                host.Run(game);
        }
    }
}
