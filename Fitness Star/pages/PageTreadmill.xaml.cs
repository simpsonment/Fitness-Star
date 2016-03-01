using System;
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

namespace Fitness_Star.pages
{
    /// <summary>
    /// Interaction logic for PageTreadmill.xaml
    /// </summary>
    public partial class PageTreadmill : Page
    {
        public PageTreadmill()
        {
            InitializeComponent();
            
            
        }

        public double bmi = new double();

        private void Button_Click(object sender, RoutedEventArgs e) //Begin Workout button, calculates mass and body mass index
        {
            if (TextBoxH.Text == "")
                MessageBox.Show("Please enter your height");
            else
            {
                Random r = new Random();
                int rInt = r.Next(50, 100);
                MessageBox.Show("Your weight is: " + rInt);
                TextBoxW.Text = "" + rInt;
                int weight = Int32.Parse (TextBoxW.Text);
                double height = Double.Parse (TextBoxH.Text);
                bmi = Math.Round(weight / Math.Pow(height / 100.0, 2));
                if (bmi<18.5)
                MessageBox.Show("Your bodymass index is: "+bmi+". This is considered underweight.");
                else if(bmi>=18.5 && bmi <25)
                    MessageBox.Show("Your bodymass index is: "+bmi+". This is considered normal.");
                else if(bmi>=25 && bmi<=30)
                    MessageBox.Show("Your bodymass index is: "+bmi+". This is considered overweight.");
                else if(bmi>30 && bmi<=35)
                    MessageBox.Show("Your bodymass index is: "+bmi+". This is considered obese.");
                else
                    MessageBox.Show("Your bodymass index is: "+bmi+". This is considered morbidly obese.");

                ButtonMeal.IsEnabled = true;
                ButtonWorkout.IsEnabled = true;
            }
        }

        private void ButtonWorkout_Click(object sender, RoutedEventArgs e)
        {
            if (bmi < 18.5)
                MessageBox.Show("You should walk at 4mph for 20 minutes five times a week.");
            else if (bmi >= 18.5 && bmi < 25)
                MessageBox.Show("You should run at 7mph for 30 minutes four times a week.");
            else if (bmi >= 25 && bmi <= 30)
                MessageBox.Show("You should walk at 5mph for 30 minutes five times a week.");
            else if (bmi > 30 && bmi <= 35)
                MessageBox.Show("You should walk at 4mph for 40 minutes five times a week.");
            else
                MessageBox.Show("You should walk at 3mph for 30 minutes four times a week.");
        }

        private void ButtonMeal_Click(object sender, RoutedEventArgs e)
        {
            MealPlan.Visibility = System.Windows.Visibility.Visible;
            if (bmi < 18.5)
                MealPlan.Text = (" Meal 1: Whole Milk, Oats, Apple \r\n Meal 2: Ground Beef, Black Beans, Tomato \r\n Meal 3: Grilled Salmon, Broccoli, Brown Rice\r\n Meal 4: Whole Milk, Plain Cheerios, Banana");
            else if (bmi >= 18.5 && bmi < 25)
                MealPlan.Text = (" Meal 1: Nonfat Milk, Oats, Almonds \r\n Meal 2: Chicken Breast, Sweet Potatoes, Spinach \r\n Meal 3: Salmon, Brown Rice, Tomato \r\n Meal 4: Nonfat Greek Yogurt, Oats, Apple");
            else if (bmi >= 25 && bmi <= 30)
                MealPlan.Text = (" Meal 1: Nonfat Quark, Whole Egg \r\n Meal 2: Grilled Tilapia, Asparagus, Coconut Oil \r\n Meal 3: Ground Turkey, Boiled Spinach, Avocado \r\n Meal 4: Nonfat Greek Yogurt, Tomato");
            else if (bmi > 30 && bmi <= 35)
                MealPlan.Text = (" Meal 1: Egg White, Oats \r\n Meal 2: Chicken Breast, Carrots \r\n Meal 3: Grilled Tilapia, Brown Rice \r\n Meal 4: Egg White, Boiled Kale");
            else
                MealPlan.Text = (" Meal 1: Soy Milk, Oats \r\n Meal 2: Black Beans, Broccoli \r\n Meal 3: Lentils, Olive Oil \r\n Meal 4: Soy Milk, Boiled Spinach");
        }


    }
}
