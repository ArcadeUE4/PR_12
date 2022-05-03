using System;
using Xamarin.Forms;

namespace PR_12
{
    public partial class MainPage : ContentPage
    {
        
        int FibonacciNumber1 = 1;
        int FibonacciNumber2 = 0;
        int Result = 0;

        public MainPage()
        {
            InitializeComponent();            
        }

       void OnButtonClicked(object sender, EventArgs e)
        {
            if (Result <= 50)
            {
            FibonacciNumber2 += FibonacciNumber1;
            Result = FibonacciNumber1;
            label.Text = Result.ToString();
            FibonacciNumber1 = FibonacciNumber2;
            FibonacciNumber2 = Result;
            label.Text = Result.ToString();
            }
        
        }

        private void Button_Pressed(object sender, EventArgs e)
        {

        }
    }
}
