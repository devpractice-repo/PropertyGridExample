using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyFontConfig
    {
        Font m_FontField;
        [Browsable(true)]
        [Description("Example of font field")]
        [DisplayName("Font field")]
        public Font FontField
        {
            get { return m_FontField; }
            set { m_FontField = value; }
        }
    }
}
