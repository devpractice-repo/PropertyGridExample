using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyTextField
    {
        String m_TextField;
        [Browsable(true)]
        [Description("Example of text field")]
        [DisplayName("Text field")]
        public String TextField
        {
            get { return m_TextField; }
            set { m_TextField = value; }
        }
    }
}
