using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RichTextBoxMaxLine
{
    // Limits output to n amount of lines, allowing for better readability (scrolls automatically always showing newest output)
    public static class ControlHelper
    {
        public static void AddLine(this RichTextBox box, string text, uint? maxLine = null)
        {
            string newLineIndicator = "\n";

            /*max line check*/
            if (maxLine != null && maxLine > 0)
            {
                if (box.Lines.Count() >= maxLine)
                {
                    List<string> lines = box.Lines.ToList();
                    lines.RemoveAt(0);
                    box.Lines = lines.ToArray();
                }                
            }

            
            string line = String.IsNullOrEmpty(box.Text) ? text : newLineIndicator + text;
            box.AppendText(line);
        }
    }
}
