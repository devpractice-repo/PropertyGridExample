using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyColorSelector
    {
        Color m_ColorField;
        [Browsable(true)]
        [Description("Example of color field")]
        [DisplayName("Color field")]
        public Color TextField
        {
            get { return m_ColorField; }
            set { m_ColorField = value; }
        }
    }
}
