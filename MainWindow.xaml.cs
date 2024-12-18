using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUI_Creature_Manager.View.CreatureWindow;
using Creature_Manager;
using System.Text.RegularExpressions;

namespace GUI_Creature_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Important methods
            //creatureListView.UnselectAll();
            //creatureListView.SelectAll();
            
           // MessageBox.Show($"{creatureListView.Items.Cast<CreatureWindow>().First().damageRoll()}");

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void addCreatureBtn_Click(object sender, RoutedEventArgs e)
        {
            if (addAmount.Text == "" || addAmount.Text == null) {
                combatLog.Text += $"\nError: Must enter amount of creatures to add!";
                return;
            }

            for (int i = 0; i < int.Parse(addAmount.Text); i++){

                creatureListView.Items.Add(createCreatureTypeWindow());

            }
        }

        private CreatureWindow? createCreatureTypeWindow() {

            switch (selectedCreatureType.SelectedValue) {
                case "Animated Obj(Tiny)":
                    return new CreatureWindow(new AnimatedObject("tiny"), "Tiny Object");

                default:
                    return null;
            }

        }

        private void attackBtn_Click(object sender, RoutedEventArgs e)
        {

            combatLog.Text += $"\n---Attack!---";

            foreach (var critter in creatureListView.SelectedItems.Cast<CreatureWindow>())
            {
                combatLog.Text += $"\n{critter.damageRoll()}";
            };

            combatLog.Text += $"\n-------------\n";

        }
    }
}