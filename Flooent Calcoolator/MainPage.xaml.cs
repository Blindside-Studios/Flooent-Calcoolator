using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Numerics;
using System.Threading.Tasks;


namespace Flooent_Calcoolator
{
    public sealed partial class MainPage : Page
    {
        int numberEdit = 1;
        int thisNumber = 0;
        int mathOP = 0;
        double solution = 0;
        
        public MainPage()
        {
            this.InitializeComponent();
        }


        private async void Equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FirstNumber.Text == "") FirstNumber.Text = "0";
                if (SecondNumber.Text == "")
                {
                    if (Operation.SelectedIndex == 3) FirstNumber.Text = "0";
                    else if (Operation.SelectedIndex == 4) FirstNumber.Text = "1";
                }

                
                Equal.Translation   = new Vector3(0, -20, 0);
                Button1.Translation = new Vector3(0, -20, 0);
                Button2.Translation = new Vector3(0, -20, 0);
                Button3.Translation = new Vector3(0, -20, 0);
                Button4.Translation = new Vector3(0, -20, 0);
                Button5.Translation = new Vector3(0, -20, 0);
                Button6.Translation = new Vector3(0, -20, 0);
                Button7.Translation = new Vector3(0, -20, 0);
                Button8.Translation = new Vector3(0, -20, 0);
                Button9.Translation = new Vector3(0, -20, 0);
                Button0.Translation = new Vector3(0, -20, 0);
                Back.Translation    = new Vector3(0, -20, 0);
                Solution.Opacity = 0;
                FirstNumber.Translation = new Vector3(0, 170, 0);
                Operation.Translation = new Vector3(500, 0, 0);
                SecondNumber.Translation = new Vector3(1000, -170, 0);
                await Task.Delay(30);

                Button1.Opacity = 0;
                Button2.Opacity = 0;
                Button3.Opacity = 0;
                Button4.Opacity = 0;
                Button5.Opacity = 0;
                Button6.Opacity = 0;
                Button7.Opacity = 0;
                Button8.Opacity = 0;
                Button9.Opacity = 0;
                Button0.Opacity = 0;
                Back.Opacity = 0;
                Equal.Opacity = 0;
                await Task.Delay(1000);
                
                Solution.Translation = new Vector3(500, -300, 0);
                Solution.Scale = new Vector3(2, 2, 2);
                await Task.Delay(400);
                
                FirstNumber.Opacity = 0;
                FirstNumber.Translation = new Vector3(500, 170, 0);
                SecondNumber.Opacity = 0;
                SecondNumber.Translation = new Vector3(500, -170, 0);
                Operation.Opacity = 0;
                await Task.Delay(350);


                int calcNum1 = Int16.Parse(FirstNumber.Text);
                int calcNum2 = Int16.Parse(SecondNumber.Text);

                if (Operation.SelectedIndex == 0) solution = calcNum1 + calcNum2;
                if (Operation.SelectedIndex == 1) solution = calcNum1 - calcNum2;
                if (Operation.SelectedIndex == 2) solution = calcNum1 * calcNum2;
                if (Operation.SelectedIndex == 3) solution = calcNum1 / calcNum2;

                Solution.Text = solution.ToString();
                Solution.Opacity = 1;
                Solution.Translation = new Vector3(500, -350, 0);
                FirstNumber.Translation = new Vector3(0, -10, 0);
                SecondNumber.Translation = new Vector3(0, -10, 0);
                Operation.Translation = new Vector3(0, -10, 0);
                await Task.Delay(1000);
                
                Solution.Translation = new Vector3(0, 0, 0);
                Solution.Scale = new Vector3(1, 1, 1);
                await Task.Delay(150);

                Equal.Translation = new Vector3(0, 0, 0);
                Button1.Translation = new Vector3(0, 0, 0);
                Button2.Translation = new Vector3(0, 0, 0);
                Button3.Translation = new Vector3(0, 0, 0);
                Button4.Translation = new Vector3(0, 0, 0);
                Button5.Translation = new Vector3(0, 0, 0);
                Button6.Translation = new Vector3(0, 0, 0);
                Button7.Translation = new Vector3(0, 0, 0);
                Button8.Translation = new Vector3(0, 0, 0);
                Button9.Translation = new Vector3(0, 0, 0);
                Button0.Translation = new Vector3(0, 0, 0);
                Back.Translation = new Vector3(0, 0, 0);
                FirstNumber.Translation = new Vector3(0, 0, 0);
                SecondNumber.Translation = new Vector3(0, 0, 0);
                Operation.Translation = new Vector3(0, 0, 0);
                Button1.Opacity = 1;
                Button2.Opacity = 1;
                Button3.Opacity = 1;
                Button4.Opacity = 1;
                Button5.Opacity = 1;
                Button6.Opacity = 1;
                Button7.Opacity = 1;
                Button8.Opacity = 1;
                Button9.Opacity = 1;
                Button0.Opacity = 1;
                Back.Opacity = 1;
                Equal.Opacity = 1;
                FirstNumber.Opacity = 1;
                SecondNumber.Opacity = 1;
                Operation.Opacity = 1;
            }
            catch
            {
                FirstNumber.Text = "Etwas";
                SecondNumber.Text = "lief";
                Solution.Text = "schief!";
            }
        }


        private void FirstNumber_GettingFocus(object sender, RoutedEventArgs e)
        {
            numberEdit = 1;
        }

        private void SecondNumber_GettingFocus(object sender, RoutedEventArgs e)
        {
            numberEdit = 2;
        }




        //Boring part with all the buttons ALSO FIX THIS FUCKING MESS


        private async void Button1_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 1;
            if (numberEdit == 1) {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button1.Translation = new Vector3(-550,0,0);
                Button1.Opacity = 0;
                await Task.Delay(250);
                Button1.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button1.Opacity = 1;            
            }
            if (numberEdit == 2) { 
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button1.Translation = new Vector3(-550, 300, 0);
                Button1.Opacity = 0;
                await Task.Delay(250);
                Button1.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button1.Opacity = 1;
            }
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 2;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button2.Translation = new Vector3(-750, 0, 0);
                Button2.Opacity = 0;
                await Task.Delay(250);
                Button2.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button2.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button2.Translation = new Vector3(-750, 300, 0);
                Button2.Opacity = 0;
                await Task.Delay(250);
                Button2.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button2.Opacity = 1;
            }
        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 3;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button3.Translation = new Vector3(-950, 0, 0);
                Button3.Opacity = 0;
                await Task.Delay(250);
                Button3.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button3.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button3.Translation = new Vector3(-950, 300, 0);
                Button3.Opacity = 0;
                await Task.Delay(250);
                Button3.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button3.Opacity = 1;
            }
        }

        private async void Button4_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 4;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button4.Translation = new Vector3(-550, -150, 0);
                Button4.Opacity = 0;
                await Task.Delay(250);
                Button4.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button4.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button4.Translation = new Vector3(-550, 150, 0);
                Button4.Opacity = 0;
                await Task.Delay(250);
                Button4.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button4.Opacity = 1;
            }
        }

        private async void Button5_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 5;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button5.Translation = new Vector3(-750, -150, 0);
                Button5.Opacity = 0;
                await Task.Delay(250);
                Button5.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button5.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button5.Translation = new Vector3(-750, 150, 0);
                Button5.Opacity = 0;
                await Task.Delay(250);
                Button5.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button5.Opacity = 1;
            }
        }

        private async void Button6_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 6;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button6.Translation = new Vector3(-950, -150, 0);
                Button6.Opacity = 0;
                await Task.Delay(250);
                Button6.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button6.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button6.Translation = new Vector3(-950, 150, 0);
                Button6.Opacity = 0;
                await Task.Delay(250);
                Button6.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button6.Opacity = 1;
            }
        }

        private async void Button7_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 7;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button7.Translation = new Vector3(-550, -300, 0);
                Button7.Opacity = 0;
                await Task.Delay(250);
                Button7.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button7.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button7.Translation = new Vector3(-550, 0, 0);
                Button7.Opacity = 0;
                await Task.Delay(250);
                Button7.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button7.Opacity = 1;
            }
        }

        private async void Button8_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 8;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button8.Translation = new Vector3(-750, -300, 0);
                Button8.Opacity = 0;
                await Task.Delay(250);
                Button8.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button8.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button8.Translation = new Vector3(-750, 0, 0);
                Button8.Opacity = 0;
                await Task.Delay(250);
                Button8.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button8.Opacity = 1;
            }
        }

        private async void Button9_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 9;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button9.Translation = new Vector3(-950, -300, 0);
                Button9.Opacity = 0;
                await Task.Delay(250);
                Button9.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button9.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button9.Translation = new Vector3(-950, 0, 0);
                Button9.Opacity = 0;
                await Task.Delay(250);
                Button9.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button9.Opacity = 1;
            }
        }

        private async void Button0_Click(object sender, RoutedEventArgs e)
        {
            thisNumber = 0;
            if (numberEdit == 1)
            {
                FirstNumber.Text = FirstNumber.Text + thisNumber;
                Button0.Translation = new Vector3(-750, -450, 0);
                Button0.Opacity = 0;
                await Task.Delay(250);
                Button0.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button0.Opacity = 1;
            }
            if (numberEdit == 2)
            {
                SecondNumber.Text = SecondNumber.Text + thisNumber;
                Button0.Translation = new Vector3(-750, -150, 0);
                Button0.Opacity = 0;
                await Task.Delay(250);
                Button0.Translation = new Vector3(0, 0, 0);
                await Task.Delay(250);
                Button0.Opacity = 1;
            }
        }

        private async void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (numberEdit == 1) FirstNumber.Text = FirstNumber.Text.Remove(FirstNumber.Text.Length-1);
                if (numberEdit == 2) SecondNumber.Text = SecondNumber.Text.Remove(SecondNumber.Text.Length - 1);
            }
            catch { }
        }

        


       
    }
}
