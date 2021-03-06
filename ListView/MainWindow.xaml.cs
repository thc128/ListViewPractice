﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                XML_Access ds = new XML_Access();
                // this.MyList.DataContext = from p in XML_Access.DataRoot.Elements() select p.Value;
                this.MyList.DataContext = from p in XML_Access.DataRoot.Elements()
                                          select new Student()
                                          {
                                              ID = int.Parse(p.Element("ID").Value),
                                              Name = p.Element("Name").Value,
                                              Year = int.Parse(p.Element("Year").Value)
                                          };
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //private void MyNewPageButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MyNewPage InstanceOfMyNewPage = new MyNewPage();
        //    NavigationService currentNavigationService = NavigationService.GetNavigationService(InstanceOfMyNewPage);
        //    currentNavigationService.Navigate("MyNewPage.xaml");
        //}
    }
}
