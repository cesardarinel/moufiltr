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

namespace CMouse
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(this.TextBox_Sensibilidad.Text);
          
           
        }
        private void Slider_ValueChanged(object sender,
        RoutedPropertyChangedEventArgs<double> e)
        {
        
            var slider = sender as Slider;
            double value = slider.Value;
            this.TextBox_Sensibilidad.Text= value.ToString("0");
        }

 /*
RegistryKey rk1 = Registry.LocalMachine;
 
Trabajando con claves:

// Nos movemos hasta la subclave donde queremos trabajar.
// El parámetro boleano indica si la abrimos en solo lectura (false)
// ó en lectura/escritura (true).
rk1 = rk1.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon",true);
 
// Si devuelve null es que la clave no existe
if (rk1 == null)
    Console.WriteLine("No existe esa clave");
 
// Crear una nueva clave
// El método devuelve un RegistryKey apuntando
// a la nueva entrada.
RegistryKey rk2 = rk1.CreateSubKey("Prueba");
 
// Obtener todas las subclaves contenidas en esta:
String[] subKeys = rk1.GetSubKeyNames();
 
// Borrar una clave vacia:
rk.DeleteSubKey("Prueba");
                
// Borrar una clave recursivamente:
rk.DeleteSubKeyTree("Prueba");
 
Trabajando con key-values:

// Crea un key-value indicando su nombre, valor y tipo:
rk2.SetValue("ValorPrueba", 0,RegistryValueKind.String);
 
// Obtener todos los nombres de key-values que hay en una clave:
String[] values = rk2.GetValueNames();
 
// Obtener el valor de un key-value:
Console.WriteLine(rk2.GetValueKind("ValorPrueba").ToString());
 
// Obtener el tipo de dato de registro 
// que contiene un key-value:
RegistryValueKind rvk = rk2.GetValueKind("ValorPrueba");
 
// Borrar un key-value:
// El parámetro boleano indica que salte una excepción
// si el key-value a borrar no existe.
rk2.DeleteValue("ValorPrueba", true);
    */
    }
}
