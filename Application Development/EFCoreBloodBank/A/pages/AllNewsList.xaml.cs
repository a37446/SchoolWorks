﻿using A.pages.Forms;
using A.ViewModel;
using BloodBank.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace A.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllNewsList : Page
    {

        public NewsVM news { get; set; }
        public object SelectedItem { get; set; }

        

        public AllNewsList()
        {
            this.InitializeComponent();
            this.news = new NewsVM();
            this.news.RetrieveAll();
        }

        private void Update_Button(object sender, RoutedEventArgs e)
        {
            var idReceiver = (sender as Button).DataContext as News;
            UpdateNews.getId = idReceiver.NewsId;
            Frame.Navigate(typeof(UpdateNews));
        }


        private  void Delete_Button(object sender, RoutedEventArgs e)
        {
            var idReceiver = (sender as Button).DataContext as News;
            int id = idReceiver.NewsId;
            news.DeleteNews(id);
            Frame.Navigate(typeof(AllNewsList));
          

        }



        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


         

        }
    }
}
