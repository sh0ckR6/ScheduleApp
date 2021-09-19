using osu.Framework.Graphics;

namespace ScheduleApp.Game.Tests.Visual
{
    public class TestSceneSpinningBox : ScheduleAppTestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneSpinningBox()
        {
            Add(new SpinningBox
            {
                Anchor = Anchor.Centre,
            });
        }
    }
}
