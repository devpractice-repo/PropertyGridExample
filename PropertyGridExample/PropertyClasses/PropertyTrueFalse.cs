using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyTrueFalse
    {
        bool m_LogicField;
        [Browsable(true)]
        [Description("Example of logic field")]
        [DisplayName("Logic field")]
        public bool LogicField
        {
            get { return m_LogicField; }
            set { m_LogicField = value; }
        }
    }
}
