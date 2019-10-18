using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.MyComponent
{
    public sealed class Language
    {
        public int Index { get; private set; }
        public string TooltipName { get; private set; }
        public string FileName { get; private set; }
        public string Caption { get; private set; }
        public bool Validate { get; private set; }
        public Language(int p_Index, string p_TooltipName, string p_FileName, string p_Caption)
        {
            Index = p_Index;
            TooltipName = p_TooltipName;
            FileName = p_FileName;
            Caption = p_Caption;
            Validate = true;
        }
    }
}
