using Microsoft.Maui.Handlers;

namespace BirthYAY.UI.Controls
{
    internal class BorderlessSearchBar : SearchBar
    {
        public BorderlessSearchBar()
        {
            ModifySearchBar();
        }

        private static void ModifySearchBar()
        {
#if ANDROID
            SearchBarHandler.Mapper.AppendToMapping("BorderlessSearchBar", (handler, view) =>
            {
                if (view is BorderlessSearchBar)
                {
                    handler.PlatformView.Background = null;
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            });
#endif
        }
    }
}
