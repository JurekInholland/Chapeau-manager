// Made by Jurek Baumann, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Manager : Form
    {
        // Used to determine the panel transition direction
        string direction;

        // Define fonts once that are used throughout
        Font fontDefault = new Font("Segore UI", 12, FontStyle.Regular);
        Font fontHeading1 = new Font("Segore UI", 20, FontStyle.Bold);
        Font fontHeading2 = new Font("Segore UI", 14, FontStyle.Bold);
        Font fontHeading3 = new Font("Segore UI", 12, FontStyle.Bold);

        // Todo: pass Order object to ctor instead of generating random test data
        //public Manager(Order order)

        public Manager()
        {
            InitializeComponent();

            //Slightly improve smoothness of timer based animations
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            //typeof(Panel).InvokeMember("DoubleBuffered",
            //BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //null, panel1, new object[] { true });

            // Setup UI properties
            //setup();

            // Init Random once here and pass it along. This is only used to generate test values.
            Random random = new Random();

            // Create a test order
            //Order testOrder = CreateTestOrder(random);

            // Create a list of orders.
            // This will be passed to the manager pane
            // and serve all required data.
            // In the future this should just be passed to the
            // constructor of this class.
            List<Order> orderList = CreateTestOrderList(random);

            foreach(Order order in orderList)
            {
                // Debug only: Print order information to console
                Console.WriteLine(order.ToString());


                // flp stands for flow layout panel.
                // It acts as container for dynamically created panels.
                // Create a history panel (main menu of manager view) and add it to the history flp.
                flpCustomerHistory.Controls.Add(createHistoryPanel(order));
            };

        }
        /// <summary>
        /// Debugging only
        /// Return a List of test Orders
        /// </summary>
        private List<Order> CreateTestOrderList(Random random)
        {
            List<Order> orderList = new List<Order>();

            // Create 6-12 test orders
            int numberOrders = random.Next(6, 12);

            for (int i = 0; i < numberOrders; i++)
            {
                orderList.Add(CreateTestOrder(random));
            }

            return orderList;
        }
        
        /// <summary>
        /// Debugging only
        /// Create an Order with random values for testing purposes
        /// </summary>
        /// <returns>An Order with sample values</returns>
        private Order CreateTestOrder(Random random)
        {
            // Provide some test values to create an Order
            // These are later replaced by values from the DB.

            int randomHour = random.Next(09, 22);
            int randomMinute = random.Next(1, 59);
            int randomMinuteEnd = random.Next(1, 59);
            int randomHourEnd = randomHour + random.Next(1, 2);
            int randomTable = random.Next(1, 11);


            // Array of menu items from which some are randomly chosen.
            string[] allMenuItems = new string[]
            {
                "Crêpe", "Pizza", "Cassoulet", "Ratatouille", "Tarte tatin",
                "Beef bourguignon", "Flamiche", "Confit de canard", "Coq au vin"
            };

            // Create an array of three random menu items
            string[] selectedMenus = new string[9];
            for (int i = 0; i < 9; i++)
            {
                int rndIndex = random.Next(0, allMenuItems.Length);
                selectedMenus[i] = allMenuItems[rndIndex];
            }

            // This is needed to convert strings to DateTime objects.
            CultureInfo dutchFormat = new CultureInfo("nl-NL");

            // Create random datetime strings
            string randomStartTime = string.Format("01.06.2019 {0:00}:{1:00}", randomHour, randomMinute);
            string randomEndTime = string.Format("01.06.2019 {0:00}:{1:00}", randomHourEnd, randomMinuteEnd);

            // Create DateTime objects
            DateTime startTime = Convert.ToDateTime(randomStartTime, dutchFormat);
            DateTime endTime = Convert.ToDateTime(randomEndTime, dutchFormat);


            // A dictionary of involved staff members. This could also be simply an array but to be sure to
            // to keep track of the respective professions, a dictionary is used.
            Dictionary<string, string> staff = new Dictionary<string, string>
            {
                { "Cook", "Luigi Marino" },
                { "Waiter", "Anouk Van de Berg" },
                { "Bartender", "Lars Van Dijk" }
            };

            string feedback = "We found the food really dope. The french do know how to cook! The staff was friendly and well informed and the food was perfect.";

            // Create a new order based on the random values
            Order order = new Order(startTime, endTime, randomTable, selectedMenus, staff, feedback: feedback);

            return order;
        }



        /// <summary>
        /// Make a smooth transition between two panels.
        /// </summary>
        private void pageTransition(string dir)
        {

            // Since it seems not intended to pass parameters to EventArgs without subclassing it,
            // we set a class variable to determine the transition direction/ mod
            // This is retrieved in the timer callback function timer1_Tick.
            direction = dir;

            // Fire a timer to *smoothly* transition between Panel positions
            timer1.Start();
        }

        /// <summary>
        /// This is called repeatedly during the panel transition animation.
        /// The values are still tweakable but already come quite close to the desired behavior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                pnlHistory.Left -= 9;
                pnlDetails.Left -= 23;

                if (pnlDetails.Left <= 0)
                {
                    timer1.Stop();
                }
            }
            else
            {
                pnlHistory.Left += 9;
                pnlDetails.Left += 23;
                
                // The panel has moved enough
                if (pnlDetails.Left >= 360)
                {
                    pnlHistory.Left = 0;
                    pnlDetails.Left = 360;
                    timer1.Stop();
                }
            }
        }

        /// <summary>
        /// Generate a panel that displays historical order information
        /// This is the manager main menu
        /// </summary>
        private Panel createHistoryPanel(Order order)
        {
            // Create Labels and put them in a TableLayoutPanel
            TableLayoutPanel headline = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 3
            };

            Label labelTime = new Label {
                Dock = DockStyle.Top,
                Size = new Size(120, 25),
                Font = fontHeading3,
                Text = order.Start + " - " + order.End,
            };

            Label labelDate = new Label {
                Dock = DockStyle.Fill,
                Font = fontHeading3,
                Text = order.Date,
                AutoSize = true
                //Size = new Size(80, 30)
            };


            Label labelTable = new Label {
                Dock = DockStyle.Right,
                AutoSize = true,
                Text = order.Table
            };

            headline.Controls.Add(labelTime);
            headline.Controls.Add(labelDate);
            headline.Controls.Add(labelTable);

            // Create Buttons
            MobileButton btnOrderDetails = new MobileButton {
                Text = "Order Details",
                Dock = DockStyle.Top,
            };
            // Pass the order to the button EventHandler
            btnOrderDetails.Click += new EventHandler((s, e) => button_Click(s, e, order));

            MobileButton btnAssignedStaff = new MobileButton
            {
                Text = "Assigned Staff",
                Dock = DockStyle.Top,
            };
            btnAssignedStaff.Click += new EventHandler((s, e) => button_Click(s, e, order));

            MobileButton btnFeedback = new MobileButton
            {
                Text = "Customer Feedback",
                Dock = DockStyle.Top,
            };
            btnFeedback.Click += new EventHandler((s, e) => button_Click(s, e, order));
            
            // Panel that holds all generated UI elements.
            Panel panel_template = new Panel {
                Size = new Size(336, 150),
                Margin = new Padding(0, 0, 0, 25)

            };

            // Add buttons to panel
            panel_template.Controls.Add(btnAssignedStaff);
            panel_template.Controls.Add(btnFeedback);
            panel_template.Controls.Add(btnOrderDetails);
            
            // Add headline labels to panel
            panel_template.Controls.Add(headline);

            return panel_template;
        }

        /// <summary>
        /// This method is called whenever one of the history view buttons
        /// is pressed. It is determined which information is shown on the details page.
        /// </summary>
        void button_Click(object sender, EventArgs e, Order order)
        {
            Button button = sender as Button;
            Console.WriteLine("Button with text {0} was clicked", button.Text);

            SetOrderValues(order.Start, order.End, order.Date, order.tableNumber);
            // Set the details pane headline to the text of the button that was clicked
            lblDetailsHeadline.Text = button.Text;

            // Clear all previous elements from details panel
            flpDetails.Controls.Clear();

            pageTransition("left");


            // Fill the flow layout panel with the respective elements.
            if (button.Text == "Order Details")
            {
                // Order details panel
                flpDetails.Controls.Add(createOrderItemsPanel(order.Menus));
            }
            else if (button.Text == "Assigned Staff")
            {
                // Staff panel
                flpDetails.Controls.Add(createAssignedStaffPanel(order.Staff));
            } else if (button.Text  == "Customer Feedback")
            {
                // Feedback panel
                flpDetails.Controls.Add(CreateCommentPanel(order.Feedback));
            }
        }

        /// <summary>
        /// Set information on the details page that are based on the respective order
        /// </summary>
        private void SetOrderValues(string startTime, string endTime, string date, int tableNr)
        {
            lblDetailsDate.Text = date;
            lblDetailsTime.Text = startTime + "-" + endTime;
            lblDetailsTable.Text = string.Format("Table {0}", tableNr);
        }



        /// <summary>
        /// Called when the Back button on the details page is pressed.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Transition back to the overview
            pageTransition("right");
        }


        /// <summary>
        /// Create a panel that displays a customer's comment
        /// </summary>
        private Panel CreateCommentPanel(string msg, string author="Anonymous")
        {
            // Create elements
            Label authorName = new Label
            {
                Text = author,
                Font = new Font("Segore UI", 14, FontStyle.Bold),
                AutoSize = true,
                MinimumSize = new Size(100, 30),
                Dock = DockStyle.Top
            };

            Label messageBox = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.None,

                Text = msg,
                Dock = DockStyle.Fill,
                MaximumSize = new Size(300, 1000),
                Font = new Font("Segore UI", 12)

            };

            Panel commentPanel = new Panel
            {
                Size = new Size(375, 1000),
                Margin = new Padding(20, 0, 0, 0),
            };

            commentPanel.Controls.Add(messageBox);
            commentPanel.Controls.Add(authorName);

            return commentPanel;
        }

        /// <summary>
        /// Create a panel that displays the assigned staff of an order
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        private Panel createAssignedStaffPanel(Dictionary<string, string> staff)
        {
            // Define fonts once
            Font fontRegular = new Font("Segore UI", 12, FontStyle.Regular);
            Font fontBold = new Font("Segore UI", 14, FontStyle.Bold);

            // Create elements
            Label cookHeadline = new Label
            {
                Dock = DockStyle.Top,
                Text = "Cook:",
                Font = fontBold,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft
                //AutoSize = true
            };

            Label cookName = new Label
            {
                Text = staff["Cook"],
                Dock = DockStyle.Top,
                BackColor = Color.White,
            };

            Label waiterHeadline = new Label
            {
                Text = "Waiter:",
                Font = fontBold,
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label waiterName = new Label
            {
                Text = staff["Waiter"],
                Dock = DockStyle.Top,
                BackColor = Color.White,
            };

            Label bartenderHeadline = new Label
            {
                Text = "Bartender:",
                Font = fontBold,
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft

            };

            Label bartenderName = new Label
            {
                Text = staff["Bartender"],
                Dock = DockStyle.Top,
                BackColor = Color.White,

            };

            Panel staffPanel = new Panel
            {
                Font = fontRegular,
                Size = new Size(375, 158),
                BackColor = Color.LightGray,
                Margin = new Padding(20, 0, 0, 0),

            };
            staffPanel.Controls.Add(bartenderName);
            staffPanel.Controls.Add(bartenderHeadline);
            staffPanel.Controls.Add(waiterName);
            staffPanel.Controls.Add(waiterHeadline);
            staffPanel.Controls.Add(cookName);
            staffPanel.Controls.Add(cookHeadline);
            
            
            
            
            
            
            
            
            
            
            

            return staffPanel;
        }

        /// <summary>
        /// Create a panel that displays all menu's of an order
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        private Panel createOrderItemsPanel(string[] menus)
        {
            Panel itemsPanel = new Panel
            {
                Size = new Size(325, 1000),
                Margin = new Padding(20, 0, 0, 0),

            };

            ListView itemsView = new ListView
            {
                Font = new Font("Segore UI", 12),
                Dock = DockStyle.Fill,
                View = View.Details,
                BorderStyle = BorderStyle.None,
                HeaderStyle = ColumnHeaderStyle.None,
            };
            itemsView.Columns.Add("col1", -1, HorizontalAlignment.Left);
            //itemsView.Scrollable = true;
            // Create a ListViewItem for each item in menus array
            foreach (string item in menus)
            {
                ListViewItem menuItem = new ListViewItem
                {
                    Text = item
                };
                itemsView.Items.Add(menuItem);
            }

            itemsPanel.Controls.Add(itemsView);
            return itemsPanel;
        }
        /// <summary>
        /// Hide the Manager window and show the Login screen
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }   
    }
}
