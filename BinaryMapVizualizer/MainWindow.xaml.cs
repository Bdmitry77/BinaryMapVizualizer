using BinaryMapCounter;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace BinaryMapVizualizer
{
	public partial class MainWindow : Window
	{
		public int counter;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnOpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text files (*.txt)|*.txt";

			if (openFileDialog.ShowDialog() == true)
			{
				txtResult.Text = File.ReadAllText(openFileDialog.FileName);

				var counter = new Counter();
				var validator = new Validator();

				txtResult.Text += "\n\n Result is " + counter.Count(validator.Validate(openFileDialog.FileName));
			}
		}
	}
}
