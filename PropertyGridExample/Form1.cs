using System;
using System.Windows.Forms;

using PropertyGridExample.PropertyClasses;

namespace PropertyGridExample
{
    public partial class Form1 : Form
    {
        private PropertyTextField prTextProp;
        private PropertyTrueFalse prLogicProp;
        private PropertyCategories prCategoryProp;
        private PropertyColorSelector prColorProp;
        private PropertyFontConfig prFontProp;
        private PropertyList prListProp;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prTextProp = new PropertyTextField();
            prLogicProp = new PropertyTrueFalse();
            prCategoryProp = new PropertyCategories();
            prColorProp = new PropertyColorSelector();
            prFontProp = new PropertyFontConfig();
            prListProp = new PropertyList();
            
            cbKindOfProps.SelectedIndex = 0;
        }

        private void cbKindOfProps_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbKindOfProps.SelectedIndex)
            {
                case 0: prgProperty.SelectedObject = prTextProp;
                    break;
                case 1: prgProperty.SelectedObject = prLogicProp;                   
                    break;
                case 2: prgProperty.SelectedObject = prCategoryProp;
                    break;
                case 3: prgProperty.SelectedObject = prColorProp;
                    break;
                case 4: prgProperty.SelectedObject = prFontProp;
                    break;
                case 5: prgProperty.SelectedObject = prListProp;
                    break;               
            }
        }
    }
}
