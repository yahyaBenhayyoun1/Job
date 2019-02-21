 using System;

using Xamarin.Forms;

namespace StructureMobile
{
    public class MyPage : ContentPage
    {
        public MyPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "TEst Num 2" }
                }
            };
        }
    }
}

