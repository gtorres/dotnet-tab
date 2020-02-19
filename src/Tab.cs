using Wizkisoft.DotNet.FluentStringRepeater;

namespace Wizkisoft.DotNet.Format.Tab
{
    public static class Tab
    {
        public static string Get(int tabCount = 1) =>
            _tab.Repeat(tabCount);

        public static void SetSize(int size) => CreateTab(size);

        public static void ResetDefaultSize() => _tab = _defaultTab;

        private static void CreateTab(int size) =>
            _tab = " ".Repeat(size);

        private static readonly string _defaultTab = "    ";

        private static string _tab = _defaultTab;
    }
}
