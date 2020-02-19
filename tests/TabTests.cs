using AutoFixture;
using FluentAssertions;
using Xunit;

namespace Wizkisoft.DotNet.Format.Tab.Test
{
    public sealed class TabTests
    {
        public sealed class GetShould
        {
            public GetShould()
            {
                Tab.ResetDefaultSize();
            }

            [Fact]
            public void HaveADefaultTabSizeOfFourSpaces()
            {
                var result = Tab.Get();

                result.Should().Be("    ", because: "The default tab size of Tab is four spaces.");
            }

            [Fact]
            public void ReturnNewTabSize_AfterNewTabSizeIsSet()
            {
                var fixture = new Fixture();
                var tabSize = fixture.Create<int>();

                Tab.SetSize(tabSize);
                var result = Tab.Get();

                result.Length.Should().Be(tabSize, because: "After the tab size is set, tab should return the new size for a call to Get()");
            }

            [Fact]
            public void ReturnDefaultTabSize_AfterResetDefaultSizeCalled()
            {
                var fixture = new Fixture();

                Tab.SetSize(fixture.Create<int>());
                Tab.ResetDefaultSize();
                var result = Tab.Get();

                result.Should().Be("    ", because: "The tab size was reset and should return the default tab size of four spaces.");
            }

            [Fact]
            public void RepeatTheTabByTheNumberPassedToTheGetCall()
            {
                var fixture = new Fixture();
                var tabCount = fixture.Create<int>();

                var result = Tab.Get(tabCount);

                result.Length.Should().Be(tabCount * 4, because: "The tab of size 4 should be repeated by the number of times given by the tab count.");
            }

            [Fact]
            public void ReturnAnEmptyString_WhenTabCountIsZero()
            {
                var result = Tab.Get(0);

                result.Length.Should().Be(0, because: "A tab count of zero indicates there should be no tabs.");
            }
        }
    }
}
