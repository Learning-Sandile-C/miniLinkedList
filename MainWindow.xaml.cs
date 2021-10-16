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

namespace linked_list
{

    public partial class MainWindow : Window
    {
        LinkedList linkedList = new LinkedList();
        List<Node> tempNodes;
        public MainWindow()
        {
            InitializeComponent();

            testingAddingToList();
        }

        private void testingAddingToList()
        {
            linkedList.Append("this is 1");
            linkedList.Append("this is 2");
            linkedList.Append("this is 3");
            linkedList.Append("this is 4");
            linkedList.Append("this is 5");
            linkedList.Append("this is 6");
            linkedList.Append("this is 7");
            linkedList.Append("this is 8");
            linkedList.Append("this is 9");
            linkedList.Append("this is 10");

            lv_moviesList.Items.Clear();

            int counter = 1;
            foreach (var item in linkedList.GetNodes())
            {
                lv_moviesList.Items.Add(counter + ": " + item.Content);
                counter++;
            }

        }

        private void Button_Click_Left(object sender, RoutedEventArgs e)
        {
            lv_moviesList.Items.Clear();

            int counter = 1;
            foreach (var item in linkedList.GetNodesBackwards())
            {
                lv_moviesList.Items.Add(counter + ": " + item.Content);
                counter++;
            }

        }


        private void Button_Click_Right(object sender, RoutedEventArgs e)
        {
            lv_moviesList.Items.Clear();

            int counter = 1; 
            foreach (var item in linkedList.GetNodes())
            {
                lv_moviesList.Items.Add(counter+": "+item.Content);
                counter++;
            }

        }

        private void btn_append_Click(object sender, RoutedEventArgs e)
        {
            linkedList.Append(tb_addText.Text);
            tb_addText.Clear();
        }

        private void btn_prepend_Click(object sender, RoutedEventArgs e)
        {
            linkedList.Prepend(tb_addText.Text);
            tb_addText.Clear();

        }

        private void lv_moviesList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int tempIndex = lv_moviesList.SelectedIndex + 1;
            btn_middle.Content = "At index: " + tempIndex;
            btn_delete.Content = "Delete at: " + tempIndex;

        }

        private void btn_middleAdd(object sender, RoutedEventArgs e)
        {
            int tempCount = lv_moviesList.SelectedIndex+1;
            linkedList.MiddleInsert(new Node(null,tb_addText.Text,null) , tempCount);

            tb_addText.Clear();

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            tb_addText.Clear();

            linkedList.Delete(lv_moviesList.SelectedIndex + 1);

        }

        private void lv_moviesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
