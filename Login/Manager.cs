// Made by Jurek Baumann, 2019

using Login.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Login
{
    /// <summary>
    /// Manager form; Display historical order/ customer information
    /// </summary>
    public partial class Manager : Form
    {

        // Used to determine the panel transition direction
        string direction;
        string Orientation;

        // Define fonts once that are used throughout
        Font fontDefault = new Font("Segore UI", 12, FontStyle.Regular);
        Font fontHeading1 = new Font("Segore UI", 20, FontStyle.Bold);
        Font fontHeading2 = new Font("Segore UI", 14, FontStyle.Bold);
        Font fontHeading3 = new Font("Segore UI", 12, FontStyle.Bold);

        // Todo: pass Order object to ctor instead of generating random test data
        //public Manager(Order order)
        public Manager(string orientation="portrait")
        {
            InitializeComponent();

            // Animations only happen in portrait mode
            Orientation = orientation;


            // Init Random once here and pass it along. This is only used to generate test values.
            Random random = new Random();

            // Create a list of orders.
            // This will be passed to the manager panel as well as details panels
            // and serve all required data. In the future this should just be
            // passed to the constructor of this class.

            // This is were all data of the manager panel comes from; A list of Orders.
            List<Order> orderList = CreateTestOrderList(random);

            foreach(Order order in orderList)
            {
                // Debug only: Print order information to console
                Console.WriteLine(order.ToString());

                // flp stands for flow layout panel.
                // It acts as container for dynamically created panels.
                // Create a history panel (Info boxes in history view)
                // for each order and add it to the history flp.
                flpCustomerHistory.Controls.Add(CreateHistoryPanel(order));
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
                orderList.Add(CreateTestOrder(random, i));
            }

            orderList.Reverse();

            return orderList;
        }
        
        /// <summary>
        /// Debugging only
        /// Create an Order with random values for testing purposes
        /// </summary>
        /// <returns>An Order with random values</returns>
        private Order CreateTestOrder(Random random, int orderNumber)
        {
            // Provide some test values to create an Order
            // These are later replaced by real values from the DB.

            int randomHour = random.Next(09, 22);
            int randomMinute = random.Next(1, 60);
            int randomMinuteEnd = random.Next(1, 60);
            int randomHourEnd = randomHour + random.Next(1, 3);
            int randomTable = random.Next(1, 12);
            int satisfaction = random.Next(0, 3);

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
            string randomStartTime = string.Format("{0:00}.06.2019 {1:00}:{2:00}",orderNumber + 1, randomHour, randomMinute);
            string randomEndTime = string.Format("{0:00}.06.2019 {1:00}:{2:00}", orderNumber + 1, randomHourEnd, randomMinuteEnd);

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

            string feedback = "We found it really dope. The french do know how to cook! The staff was friendly and well informed and the food was tasty af.";

            // Create a new order based on the random values
            Order order = new Order(startTime, endTime, randomTable, selectedMenus, staff, satisfaction, feedback: feedback);

            return order;
        }


        /// <summary>
        /// Make a smooth transition between two panels.
        /// </summary>
        private void PageTransition(string dir)
        {
            // If in potrait mode, transition the details panel postion on top of the history panel.
            // In landscape mode do nothing since both panels are displayed next to each other.
            if (Orientation == "portrait") {
                // Since it seems not intended to pass parameters to EventArgs without subclassing it,
                // we set a class variable to determine the transition direction
                // This is retrieved in the timer callback function (animationTick).
                direction = dir;

                // Fire a timer to *smoothly* transition between Panel positions
                animationTimer.Start();
            }
        }

        /// <summary>
        /// This is called repeatedly during the panel transition animation.
        /// The values are still tweakable but already come quite close to the desired behavior.
        /// </summary>
        private void AnimationTick(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                pnlDetails.BringToFront();

                pnlHistory.Left -= 10;
                pnlDetails.Left -= 25;

                if (pnlDetails.Left <= 0)
                {
                    pnlDetails.Left = 0;
                    pnlHistory.Left = -360;
                    animationTimer.Stop();
                }
            }
            else if (direction == "right")
            {
                pnlHistory.BringToFront();

                pnlHistory.Left += 25;
                pnlDetails.Left += 10;
                
                if (pnlHistory.Left >= 0)
                {
                    pnlHistory.Left = 0;
                    pnlDetails.Left = 360;
                    animationTimer.Stop();
                }
            }
        }

        /// <summary>
        /// Generate a panel that displays historical order information
        /// This is the manager main menu.
        /// </summary>
        private Panel CreateHistoryPanel(Order order)
        {
            // Create Labels and put them in a TableLayoutPanel
            TableLayoutPanel headline = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                ColumnCount = 3
            };

            IconLabel labelTime = new IconLabel
            {
                Dock = DockStyle.Left,
                Size = new Size(130, 20),
                Font = fontHeading3,
                Text = order.Start + " - " + order.End,
                LabelIcon = new Bitmap(Resources.clock_icon)

            };

            // The smiley that indicates customer satisfaction
            // is the icon of the Date IconLabel. It is debateable if 
            // this is the cleanest way to display it..
            Bitmap smiley;

            switch (order.Satisfaction)
            {
                case 0:
                    smiley = new Bitmap(Resources.Smiley_sad);
                    break;
                case 1:
                    smiley = new Bitmap(Resources.Smiley_neutral);
                    break;
                default:  // Use default here to always have smiley defined
                    smiley = new Bitmap(Resources.Smiley_happy);
                    break;
            }

            IconLabel labelDate = new IconLabel
            {
                Dock = DockStyle.Fill,
                Font = fontHeading3,
                Size = new Size(145, 20),
                Text = order.Date,
                IconPosition = "right",
                LabelIcon = smiley
            };


            IconLabel labelTable = new IconLabel {
                Font = fontHeading3,
                Text = order.TableNumber.ToString(),
                Size = new Size(55, 20),
                LabelIcon = new Bitmap(Resources.Table)
            };

            // Add headline labels to header panel
            headline.Controls.Add(labelTime);
            headline.Controls.Add(labelDate);
            headline.Controls.Add(labelTable);

            // Create Buttons
            MobileButton btnOrderDetails = new MobileButton {
                Text = "Order Details",
                Dock = DockStyle.Top,
            };
            // Pass the order to the button EventHandler
            btnOrderDetails.Click += new EventHandler((s, e) => HistoryButtonClick(s, e, order));

            MobileButton btnAssignedStaff = new MobileButton
            {
                Text = "Assigned Staff",
                Dock = DockStyle.Top,
            };
            btnAssignedStaff.Click += new EventHandler((s, e) => HistoryButtonClick(s, e, order));

            MobileButton btnFeedback = new MobileButton
            {
                Text = "Customer Feedback",
                Dock = DockStyle.Top,
            };
            btnFeedback.Click += new EventHandler((s, e) => HistoryButtonClick(s, e, order));
            
            // Panel that holds all generated UI elements (for one order).
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
        void HistoryButtonClick(object sender, EventArgs e, Order order)
        {
            Button button = sender as Button;

            SetOrderValues(order.Start, order.End, order.Date, order.TableNumber);
            // Set the details pane headline to the text of the button that was clicked
            lblDetailsHeadline.Text = button.Text;

            // Clear all previous elements from details panel
            flpDetails.Controls.Clear();

            PageTransition("left");


            // Fill the flow layout panel with the respective elements.
            if (button.Text == "Order Details")
            {
                // Order details panel
                flpDetails.Controls.Add(CreateOrderItemsPanel(order.Menus));
            }
            else if (button.Text == "Assigned Staff")
            {
                // Staff panel
                flpDetails.Controls.Add(CreateAssignedStaffPanel(order.Staff));
            }
            else if (button.Text  == "Customer Feedback")
            {
                // Feedback panel
                flpDetails.Controls.Add(CreateCommentPanel(order.Feedback));
            }
        }

        /// <summary>
        /// Set information on the details page that are based on the respective order
        /// and the same regardless of which information is shown
        /// Todo: Discuss if icons would be beneficial here
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
        private void BackClick(object sender, EventArgs e)
        {
            // Transition back to the overview
            PageTransition("right");
        }

        // ****************************************************************************************
        // The following methods return the respective information panels

        /// <summary>
        /// Create a panel that displays a customer's comment
        /// If no author is passed, "Anonymous" is used.
        /// </summary>
        private Panel CreateCommentPanel(string msg, string author="Anonymous")
        {
            // Create elements
            Label authorName = new Label
            {
                Text = author,
                Font = new Font("Segore UI", 14, FontStyle.Bold),
                AutoSize = true,
                MinimumSize = new Size(100, 30),  // Create a margin below the headline
                Dock = DockStyle.Top
            };

            Label messageBox = new Label
            {
                AutoSize = true,
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
        private Panel CreateAssignedStaffPanel(Dictionary<string, string> staff)
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
        /// Create a panel that displays all menu items of an order
        /// inside a listview
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        private Panel CreateOrderItemsPanel(string[] menus)
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

            // Create a ListViewItem for each item in menus array
            foreach (string item in menus)
            {
                ListViewItem menuItem = new ListViewItem
                {
                    Text = item
                };
                // Add item to view
                itemsView.Items.Add(menuItem);
            }
            // Add view to panel
            itemsPanel.Controls.Add(itemsView);
            return itemsPanel;
        }

        /// <summary>
        /// Hide the Manager window and show the Login screen when the
        /// Logout button is pressed.
        /// </summary>
        private void LogoutClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
