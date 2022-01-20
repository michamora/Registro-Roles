using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Registro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object Utilidades;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Roles rol = new Roles(RolIDTextBox.Text);

          var paso = RolesBLL.Insertar(rol);

          if (paso)
          {
          MessageBox.Show("Rol añadido con exito");
          }
          else 
          MessageBox.Show("No se pudo añadir este rol");
        }
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
    {
         Roles rol = new Roles(RolIDTextBox.Text);
         var paso = RolesBLL.Eliminar(rol);
         if (paso)
        {
            Limpiar();
            MessageBox.Show("Registro Eliminado");
        }
        else 
        MessageBox.Show("No fue posible eliminar");
    }

        private void Limpiar()
        {
            throw new System.NotImplementedException();
        }

        private void ValidarButton_Click(object sender, RoutedEventArgs e)  
{  
    if (string.IsNullOrWhiteSpace(this.RolIDTextBox.Text))  
        MessageBox.Show("El campo Rol ID se debe rellenar.");  
        else 
        MessageBox.Show("Campo validado correctamente");
}
    }
    }

    


