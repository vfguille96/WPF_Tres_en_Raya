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

namespace PROG_REL9_EJ20_Vera_G
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int jugada = 0;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button0_0_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button0_0.Focusable = false;
				Button0_0.Content = "X";
				Button0_0.FontSize = 102;
				Button0_0.FontWeight = FontWeights.Bold;
				Button0_0.Foreground = new SolidColorBrush(Colors.Red);
				Button0_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_0.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button0_0.Focusable = false;
				Button0_0.Content = "O";
				Button0_0.FontSize = 102;
				Button0_0.FontWeight = FontWeights.Bold;
				Button0_0.Foreground = new SolidColorBrush(Colors.Blue);
				Button0_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_0.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button0_1_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button0_1.Focusable = false;
				Button0_1.Content = "X";
				Button0_1.FontSize = 102;
				Button0_1.FontWeight = FontWeights.Bold;
				Button0_1.Foreground = new SolidColorBrush(Colors.Red);
				Button0_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_1.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button0_1.Focusable = false;
				Button0_1.Content = "O";
				Button0_1.FontSize = 102;
				Button0_1.FontWeight = FontWeights.Bold;
				Button0_1.Foreground = new SolidColorBrush(Colors.Blue);
				Button0_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_1.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button0_2_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button0_2.Focusable = false;
				Button0_2.Content = "X";
				Button0_2.FontSize = 102;
				Button0_2.Foreground = new SolidColorBrush(Colors.Red);
				Button0_2.FontWeight = FontWeights.Bold;
				Button0_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_2.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button0_2.Focusable = false;
				Button0_2.Content = "O";
				Button0_2.FontSize = 102;
				Button0_2.FontWeight = FontWeights.Bold;
				Button0_2.Foreground = new SolidColorBrush(Colors.Blue);
				Button0_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button0_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button0_2.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button1_0_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button1_0.Focusable = false;
				Button1_0.Content = "X";
				Button1_0.FontSize = 102;
				Button1_0.FontWeight = FontWeights.Bold;
				Button1_0.Foreground = new SolidColorBrush(Colors.Red);
				Button1_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_0.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button1_0.Focusable = false;
				Button1_0.Content = "O";
				Button1_0.FontSize = 102;
				Button1_0.FontWeight = FontWeights.Bold;
				Button1_0.Foreground = new SolidColorBrush(Colors.Blue);
				Button1_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_0.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button1_1_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button1_1.Focusable = false;
				Button1_1.Content = "X";
				Button1_1.FontSize = 102;
				Button1_1.FontWeight = FontWeights.Bold;
				Button1_1.Foreground = new SolidColorBrush(Colors.Red);
				Button1_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_1.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button1_1.Focusable = false;
				Button1_1.Content = "O";
				Button1_1.FontSize = 102;
				Button1_1.FontWeight = FontWeights.Bold;
				Button1_1.Foreground = new SolidColorBrush(Colors.Blue);
				Button1_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_1.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button1_2_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button1_2.Focusable = false;
				Button1_2.Content = "X";
				Button1_2.FontSize = 102;
				Button1_2.FontWeight = FontWeights.Bold;
				Button1_2.Foreground = new SolidColorBrush(Colors.Red);
				Button1_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_2.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button1_2.Focusable = false;
				Button1_2.Content = "O";
				Button1_2.FontSize = 102;
				Button1_2.FontWeight = FontWeights.Bold;
				Button1_2.Foreground = new SolidColorBrush(Colors.Blue);
				Button1_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button1_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button1_2.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button2_0_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button2_0.Focusable = false;
				Button2_0.Content = "X";
				Button2_0.FontSize = 102;
				Button2_0.FontWeight = FontWeights.Bold;
				Button2_0.Foreground = new SolidColorBrush(Colors.Red);
				Button2_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_0.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button2_0.Focusable = false;
				Button2_0.Content = "O";
				Button2_0.FontSize = 102;
				Button2_0.FontWeight = FontWeights.Bold;
				Button2_0.Foreground = new SolidColorBrush(Colors.Blue);
				Button2_0.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_0.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_0.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button2_1_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button2_1.Focusable = false;
				Button2_1.Content = "X";
				Button2_1.FontSize = 102;
				Button2_1.FontWeight = FontWeights.Bold;
				Button2_1.Foreground = new SolidColorBrush(Colors.Red);
				Button2_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_1.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button2_1.Focusable = false;
				Button2_1.Content = "O";
				Button2_1.FontSize = 102;
				Button2_1.FontWeight = FontWeights.Bold;
				Button2_1.Foreground = new SolidColorBrush(Colors.Blue);
				Button2_1.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_1.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_1.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Button2_2_Click(object sender, RoutedEventArgs e)
		{
			if (jugada % 2 == 0)
			{
				Button2_2.Focusable = false;
				Button2_2.Content = "X";
				Button2_2.FontSize = 102;
				Button2_2.FontWeight = FontWeights.Bold;
				Button2_2.Foreground = new SolidColorBrush(Colors.Red);
				Button2_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_2.IsEnabled = false;
				lblJugador.Content = "O";
				lblJugador.Foreground = new SolidColorBrush(Colors.Blue);
			}
			else
			{
				Button2_2.Focusable = false;
				Button2_2.Content = "O";
				Button2_2.FontSize = 102;
				Button2_2.FontWeight = FontWeights.Bold;
				Button2_2.Foreground = new SolidColorBrush(Colors.Blue);
				Button2_2.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
				Button2_2.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
				jugada++;
				Button2_2.IsEnabled = false;
				lblJugador.Content = "X";
				lblJugador.Foreground = new SolidColorBrush(Colors.Red);
			}
			Comprobar();
		}

		private void Comprobar()
		{
			// Fila 1 H
			if (Button0_0.Content == "X" && Button0_1.Content == "X" && Button0_2.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_0.Content == "O" && Button0_1.Content == "O" && Button0_2.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// Fila 2 H
			if (Button1_0.Content == "X" && Button1_1.Content == "X" && Button1_2.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button1_0.Content == "O" && Button1_1.Content == "O" && Button1_2.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// Fila 3 H
			if (Button2_0.Content == "X" && Button2_1.Content == "X" && Button2_2.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button2_0.Content == "O" && Button2_1.Content == "O" && Button2_2.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// -----------------------------------------

			// Fila 1 V
			if (Button0_0.Content == "X" && Button1_0.Content == "X" && Button2_0.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_0.Content == "O" && Button1_0.Content == "O" && Button2_0.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// Fila 2 V
			if (Button0_1.Content == "X" && Button1_1.Content == "X" && Button2_1.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_1.Content == "O" && Button1_1.Content == "O" && Button2_1.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// Fila 3 V
			if (Button0_2.Content == "X" && Button1_2.Content == "X" && Button2_2.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_2.Content == "O" && Button1_2.Content == "O" && Button2_2.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// ----------------------------------

			// Fila \
			if (Button0_0.Content == "X" && Button1_1.Content == "X" && Button2_2.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_0.Content == "O" && Button1_1.Content == "O" && Button2_2.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			// Fila /
			if (Button0_2.Content == "X" && Button1_1.Content == "X" && Button2_0.Content == "X")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR X\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (Button0_2.Content == "O" && Button1_1.Content == "O" && Button2_0.Content == "O")
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("GANADOR JUGADOR O\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}

			if (jugada == 9)
			{
				lblJugador.Content = "";
				lblTurno.Content = "¡FIN DEL JUEGO!";

				if (MessageBox.Show("EMPATE\n\n¿Desea volver a jugar?", "FIN DEL JUEGO", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
					Reiniciar();
				else
					Environment.Exit(0);
			}
		}

		private void Reiniciar()
		{
			Button0_0.Content = "";
			Button0_1.Content = "";
			Button0_2.Content = "";

			Button1_0.Content = "";
			Button1_1.Content = "";
			Button1_2.Content = "";

			Button2_0.Content = "";
			Button2_1.Content = "";
			Button2_2.Content = "";

			Button0_0.IsEnabled = true;
			Button0_1.IsEnabled = true;
			Button0_2.IsEnabled = true;

			Button1_0.IsEnabled = true;
			Button1_1.IsEnabled = true;
			Button1_2.IsEnabled = true;

			Button2_0.IsEnabled = true;
			Button2_1.IsEnabled = true;
			Button2_2.IsEnabled = true;

			jugada = 0;
			lblTurno.Content = "TURNO JUGADOR";
			lblJugador.Content = "X";
			lblJugador.Foreground = new SolidColorBrush(Colors.Red);
		}
	}
}