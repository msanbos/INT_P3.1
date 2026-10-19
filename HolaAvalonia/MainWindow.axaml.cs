using Avalonia.Controls;
using Avalonia.Media; //Para usar el método Bushes.Crimson 
using Avalonia; //Para usar Thickness
using Avalonia.Interactivity; //Para las acciones del click

namespace HolaAvalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Lo que escribas a partir de aquí se ejecuta después de cargar el XAML
        Title = "Título cambiado desde C#";
        saludo.Text = "Este texto lo ha puesto el C#";
        saludo.Foreground = Brushes.Crimson;

        var extra = new Button        
        {
            Content = "Botón creado en C#",
            Margin = new Thickness(0, 10, 0, 0)
        };
        // Dentro del constructor, después de crear el botón extra:
        boton.Click += Boton_Click;
        // Dentro del constructor, justo después de crear el botón extra:
        extra.Click += AbrirVentanaCS; 

        panel.Children.Add(extra);
        //panel.Children.Insert(0, extra); Lo incluye en una posición concreta.        

        
    }
    // Método nuevo de la clase MainWindow (fuera del constructor):
    private void Boton_Click(object? sender, RoutedEventArgs e)
    {
        saludo.Text = "He sido pulsado!";
    }

    // Método nuevo de la clase MainWindow:
    private void AbrirVentanaCS(object? sender, RoutedEventArgs e)
    {        
        new VentanaCS().Show();
    }



}