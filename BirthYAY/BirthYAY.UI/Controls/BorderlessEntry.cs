using Microsoft.Maui.Handlers;

namespace BirthYAY.UI.Controls
{
    internal class BorderlessEntry : Entry
    {
        public BorderlessEntry()
        {
            ModifyEntry();
        }

        static void ModifyEntry()
        {
#if ANDROID
            EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
                {
                    if (view is BorderlessEntry)
                    {
                        handler.PlatformView.Background = null;
                        handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    }
                });
#endif
        }
    }
}
