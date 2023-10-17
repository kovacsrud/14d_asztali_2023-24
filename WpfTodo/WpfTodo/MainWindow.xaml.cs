using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfTodo.Models;

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TodoContext todocontext;
        public ObservableCollection<Todo> Todos { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            todocontext = new TodoContext();
            //todocontext.Add(new Todo { Title="Teszt",Completed=false});
            //todocontext.SaveChanges();
            todocontext.Todos.Load();
            Todos = todocontext.Todos.Local.ToObservableCollection();
            
            DataContext = Todos;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result=todocontext.SaveChanges();
                if (result>0)
                {
                    datagridTodos.Items.Refresh();
                    MessageBox.Show("Adatok mentve!");
                } else
                {
                    MessageBox.Show("Nem történt mentés!");
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
