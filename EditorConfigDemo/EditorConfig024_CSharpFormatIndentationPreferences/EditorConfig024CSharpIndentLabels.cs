using System;

namespace EditorConfigDemo.EditorConfig024_CSharpFormatIndentationPreferences
{
    // csharp_indent_labels= no_change
    class EditorConfig024CSharpIndentLabels
    {
        private string MyMethod()
        {
            var condition = false;
            if (condition)
            {
                goto error;
            }
        error:
            throw new Exception();
        }
    }
}
