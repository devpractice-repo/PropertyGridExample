using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyCategories
    {
        String m_TextParam1;
        [Browsable(true)]
        [Description("Property: Text param 1")]
        [Category("Text params")]
        [DisplayName("Text param 1")]
        public String TextParam1
        {
            get { return m_TextParam1; }
            set { m_TextParam1 = value; }
        }

        String m_TextParam2;
        [Browsable(true)]
        [Description("Property: Text param 2")]
        [Category("Text params")]
        [DisplayName("Text param 2")]
        public String TextParam2
        {
            get { return m_TextParam2; }
            set { m_TextParam2 = value; }
        }

        bool m_LogicParam1;
        [Browsable(true)]        
        [Description("Property: Logic param 1")]
        [Category("Logic params")]
        [DisplayName("Logic param 1")]
        public bool LogicParam1
        {
            get { return m_LogicParam1; }
            set { m_LogicParam1 = value; }
        }

        bool m_LogicParam2;
        [Browsable(true)]        
        [Description("Property: Logic param 2")]
        [Category("Logic params")]
        [DisplayName("Logic param 1")]
        public bool LogicParam2
        {
            get { return m_LogicParam2; }
            set { m_LogicParam2 = value; }
        }
    }
}
