namespace EditorConfigDemo.EditorConfig002_IndentStyle
{
    public class EditorConfig002IndentStyle
    {
        public string Test()
        {
            // 在 return 前按下 tab，該行會變成用 tab 顯示
            // 打開 Tools -> Options -> Text Editor -> General -> View whitespace 會看的更清楚
            // 雖然會用 tab 顯示，但在進行 format 時，依然會變成空白，應該是 bug
            return "Mike";
        }
    }
}
