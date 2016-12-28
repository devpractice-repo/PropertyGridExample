using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PropertyGridExample.PropertyClasses
{
    class PropertyList
    {
        Direction m_dir;
        [DisplayName("Direction")]
        [Description("Direction property")]        
        [TypeConverter(typeof(DirConverter))]
        public Direction Dir
        {
            get
            {
                return m_dir;
            }
            set
            {
                m_dir = value;
            }
        }       
    }

    enum Direction
    {
        [Description("UP")]
        UP,
        [Description("DOWN")]
        DOWN,
        [Description("RIGHT")]
        RIGHT,
        [Description("LEFT")]
        LEFT
    }

    class DirConverter : EnumConverter
    {
        private Type type;
        
        public DirConverter(Type type)
            : base(type)
        {
            this.type = type;
        }

        public override object ConvertTo(ITypeDescriptorContext cntx, CultureInfo cult, object value, Type destType)
        {
            FieldInfo fieldInfo = type.GetField(Enum.GetName(type, value));
            DescriptionAttribute descAtt = 
                (DescriptionAttribute)Attribute.GetCustomAttribute(
                fieldInfo, typeof(DescriptionAttribute));

            if (descAtt != null)
            {
                return descAtt.Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext cntx, CultureInfo cult, object value)
        {
            foreach (FieldInfo fieldInfo in type.GetFields())
            {
                DescriptionAttribute descAtt = (DescriptionAttribute)Attribute.GetCustomAttribute(
                    fieldInfo, typeof(DescriptionAttribute));

                if ((descAtt != null) && ((string)value == descAtt.Description))
                {
                    return Enum.Parse(type, fieldInfo.Name);
                }
            }
            return Enum.Parse(type, (string)value);
        }
    }
}
