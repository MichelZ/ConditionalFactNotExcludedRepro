using Microsoft.DotNet.XUnitExtensions.Attributes;

namespace JustTest
{
    public class ATestThatShouldBe
    {
        public static bool ShouldThisRun => false;

        [ConditionalFact(nameof(ShouldThisRun))]
        public void IgnoredUsingConditionalFact()
        {
            Assert.Fail("This should not see the light of day");
        }

        [ConditionalFact(typeof(ShouldRun), nameof(ShouldRun.AbsolutlyNot))]
        public void IgnoredUsingConditionalFactWithClass()
        {
            Assert.Fail("This should not see the light of day");
        }

        [ConditionalFact(typeof(ShouldRun), nameof(ShouldRun.Nope))]
        public void IgnoredUsingConditionalFactWithClassField()
        {
            Assert.Fail("This should not see the light of day");
        }

        [ConditionalFact(typeof(ShouldRun), nameof(ShouldRun.HellNo))]
        public void IgnoredUsingConditionalFactWithClassMethod()
        {
            Assert.Fail("This should not see the light of day");
        }

        [SkipOnPlatform(TestPlatforms.Any, "Just for fun!")]
        public void IgnoredUsingSkipOn()
        {
            Assert.Fail("This should not see the light of day");
        }

        [ActiveIssue("Dummy")]
        public void IgnoredUsingActiveIssue()
        {
            Assert.Fail("This should not see the light of day");
        }

        [ConditionalTheory(nameof(ShouldThisRun))]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void IgnoredUsingConditionalTheory(int value)
        {
            Assert.Fail($"This should not see the light of day {value}");
        }
    }
}