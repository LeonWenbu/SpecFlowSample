using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    public class TestBase
    {
        [BeforeScenario(Order = 0)]
        public void CleanDatabase0()
        {
            // we need to run this first...
        }

        [BeforeScenario(Order = 1)]
        public void CleanDatabase1()
        {
            // we need to run this first...
        }

        [BeforeScenario(Order = 99)]
        public void CleanDatabase2()
        {
            // we need to run this first...
        }
    }
}