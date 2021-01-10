using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace GtkDemo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int count;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            lblTxt.Text = $"你点了{count}次";
        }
    }
}
