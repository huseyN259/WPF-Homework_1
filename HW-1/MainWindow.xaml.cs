using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace HW;

#nullable disable

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	Random random = new Random();
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		var button = sender as Button;
		button.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255)));

		MessageBox.Show(button.Content.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
	{
		var button = sender as Button;
		Title = button.Content.ToString();

		Grid.Children.Remove(button);

		MessageBox.Show("Deleted", "", MessageBoxButton.OK, MessageBoxImage.Information);
	}
}