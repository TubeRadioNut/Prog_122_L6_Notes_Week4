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

namespace Prog_122_L6_Notes_Week4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> items = new List<string>();
        List<string> dndList = new List<string> {
                "Healing Potion",
                "Longsword",
                "Chain Mail",
                "Dwarven Throwing Axe",
                "Spellbook",
                "Rope (50 ft.)",
                "Tinderbox",
                "Backpack",
                "Bedroll",
                "Flask of Alchemist's Fire"  // A slightly more exciting item!
            };
        List<Person> people = new List<Person>();
        List<string> cranes = new List<string>
        {
            "RT65S",
            "RT865BXL",
            "GMK7450",
            "GMK5350",
            "RT635C"
        };
        
        public MainWindow()
        {
            InitializeComponent();

            items.Add("Rafael");
            items.Add("Charles");
            items.Add("Will");
            items.Add("Dillon");
            items.Add("Mimic");
            items.Add("Longsword");

            //PopulateListBox(dndList,lbDisplay.Items);
            //PopulateListBox(items, cmbNames.Items);

            people.Add(new Person("Rafeal", "Banderas", dndList));
            people.Add(new Person("Charles", "Conan", cranes));
            people.Add(new Person("Will", "Calvera", items));
            //.ItemsSource
            cmbNames.ItemsSource = people;
            cmbNames.SelectedIndex = 0;

            

        }//end of mainwindow() class

        public void PopulateListBox(List<string> items, ItemCollection itemCollection)
        {
            itemCollection.Clear();
            foreach(string item in items)
            {
                itemCollection.Add(item);
            }
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //How do we get the selected iden?
            //.Selected
            //.SelectedIndex
            int selectedIndex = lbDisplay.SelectedIndex;
            lblCurrentSectionIndex.Content = selectedIndex;
            //.SelectedValue
            string selectedValue = lbDisplay.SelectedValue.ToString();
            lblCurrentSelectedItem.Content = selectedValue;
            //getting the selected value
            //.SelectedItem
            if(lbDisplay.SelectedValue != null)
            {
                string value = lbDisplay.SelectedValue.ToString();
                lblCurrentSelectedItem.Content = value;
            }

        }// lblDisplay_SectionChanged

        //ComboBox

        //ListBox

        public void AddExamples()
        {
            //How do we add data to the list box
            //.Items is the interal list for listbox
            //that holds the items that will be displayed
            lbDisplay.Items.Add("Charles");
            lbDisplay.Items.Add("Mimic");
            lbDisplay.Items.Add("Longsword");

            // Rafael
            //Charles
            //Will
            //Dillon
            cmbNames.Items.Add("Rafael");
            cmbNames.Items.Add("Charles");
            cmbNames.Items.Add("Will");
            cmbNames.Items.Add("Dillon");
            //assign the docmbboxes currently selected index to out new label here
            lblCmbSlectedIndex.Content = cmbNames.SelectedIndex;
        }

        private void cmbNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedCmbIndex = cmbNames.SelectedIndex;

            lbDisplay.ItemsSource = people[selectedCmbIndex].PersonalList;
        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            //grab the selected index for the combo box
            int selectedCmbIndex = cmbNames.SelectedIndex;

            //grab the string from text box
            string uservalue = txtAddToList.Text;

            //Access the selected persons list
            List<string> userList = people[selectedCmbIndex].PersonalList;
            
            //Add the string to the selected persons list
            userList.Add(uservalue);

            //refresh the list box
            lbDisplay.Items.Refresh();
        }//end of btnAddToList_Click
    }//end of partial class

}//end of namespace