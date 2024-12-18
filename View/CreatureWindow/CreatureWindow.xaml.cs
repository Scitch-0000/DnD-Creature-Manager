using Creature_Manager;
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

namespace GUI_Creature_Manager.View.CreatureWindow
{
    /// <summary>
    /// Interaction logic for CreatureWindow.xaml
    /// </summary>
    public partial class CreatureWindow : UserControl
    {

        private Creature creature;

        //public CreatureWindow()
        //{
        //    InitializeComponent();

        //    //NOTE TO SELF: Images need to have their build action set to resource or they won't show up at runtime!

        //    Uri resourceUri = new Uri("/Assets/spoon.jpg", UriKind.Relative);

        //    creaturePortrait.Source = new BitmapImage(resourceUri);
        //}

        public CreatureWindow(Creature newCreature, string name)
        {
            InitializeComponent();

            creature = newCreature;

            Uri resourceUri = new Uri("/Assets/spoon.jpg", UriKind.Relative);

            creaturePortrait.Source = new BitmapImage(resourceUri);

            creatureName.Text = name;
        }

        public string damageRoll() {

            return creature.rollAttack(creatureName.Text);

        }
    }
}
