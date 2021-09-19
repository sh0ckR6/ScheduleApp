using osu.Framework.Testing;

namespace ScheduleApp.Game.Tests.Visual
{
    public class ScheduleAppTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new ScheduleAppTestSceneTestRunner();

        private class ScheduleAppTestSceneTestRunner : ScheduleAppGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
