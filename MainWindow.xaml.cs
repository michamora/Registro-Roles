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
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using BLL;

namespace Registro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Roles roles = new Roles();
            FechaTextBox.Text = Convert.ToString(roles.Fecha);

            var lista = RolesBLL.GetLista();
            BaseDatos.ItemsSource = lista;
        }
         private void Limpiar()
        {
            RolIdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;

            
        }

        private void GuardarButton_Click(Object guardar, RoutedEventArgs e) //Boton Guardar.
        {
            var rolId = RolIdTextBox.Text;

            var descripcion = DescripcionTextBox.Text;

            Roles nuevo = new Roles(rolId, descripcion);

            FechaTextBox.Text = Convert.ToString(nuevo.Fecha); //El TextBox de Fecha tome la fecha actual.

            var confirmacion = RolesBLL.Insertar(nuevo);

            if(confirmacion)
            {
                MessageBox.Show("Rol guardado exitosamente"); //Indicando que se ha guardado el Rol/s ingresado.
                var lista = RolesBLL.GetLista();
                BaseDatos.ItemsSource = lista;
            }
            else
            {
                MessageBox.Show("Error, no se ha podido guardar...");
            }
        }

        private void EditarButton_Click(Object editar, RoutedEventArgs e) //Boton Editar.
        {
                //Editar rol
        }
        

        private void EliminarButton_Click(Object eliminar, RoutedEventArgs e) //Boton Eliminar.
        { 
            int id;
            int.TryParse(RolIdTextBox.Text, out id);
            
            
            Limpiar();

               if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Error, no se pudo eliminar", "Fallo");
            }

        }
}
    


