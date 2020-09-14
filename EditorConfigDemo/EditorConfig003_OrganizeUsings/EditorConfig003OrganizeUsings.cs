// 隨意排序的 using，使用 format 功能時會自動排序 using (預設依文字排序)
// 設定 dotnet_separate_import_directive_groups = true 代表系統 namespace 和非系統 namespace 會用空行隔開
// 設定 dotnet_sort_system_directives_first = true 代表系統 namespace 會先放在最上面排序，其餘在之後進行排序
using System.Linq;
using EditorConfigDemo.EditorConfig002_IndentStyle;
using System.IO;

// 以下是 format 後的結果
// (Ststem.* 會放在最上面，因為設定 dotnet_sort_system_directives_first = true)
// using System.IO;
// using System.Linq;
// (隔開一行，因為設定 dotnet_separate_import_directive_groups = true)
// using EditorConfigDemo.EditorConfig002_IndentStyle;

namespace EditorConfigDemo.EditorConfig003_OrganizeUsings
{
    public class EditorConfig003OrganizeUsings
    {
        public EditorConfig003OrganizeUsings()
        {
            EditorConfig002IndentStyle identStyle = new EditorConfig002IndentStyle();

            string[] lines = File.ReadAllLines("test.txt");
            lines.Select(line => $"---{lines}---");
        }
    }
}
