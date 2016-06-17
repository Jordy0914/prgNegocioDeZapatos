using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace prgNegocioDeZapatos
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            // Add dummy data to the listview
            //seedListView();
        }



        /*cuadro
       private void seedListView()
       {
           //Define
           var data = new[]
           {
               new []{"Lollipop", "392", "0.2", "0"},
               new []{"KitKat", "518", "26.0", "7"},
               new []{"Ice cream sandwich", "237", "9.0", "4.3"},
               new []{"Jelly Bean", "375", "0.0", "0.0"},
               new []{"Honeycomb", "408", "3.2", "6.5"}
           };

           //Add
           foreach (string[] version in data)
           {
               var item = new ListViewItem(version);
               materialListView1.Items.Add(item);
           }
       }*/
    }
}
