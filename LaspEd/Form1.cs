using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaspEd
{
    public partial class Form1 : TitleBarTabs
    {
        public Form1()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                    Content = new Form2
                    {
                        Text = "New Tab"
                    }
            }; 
        } 

    }
}
