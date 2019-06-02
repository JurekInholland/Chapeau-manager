using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    
    public partial class Manager : Form
    {
        string direction = "right";

        public Manager()
        {
            InitializeComponent();
            setup();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // Init Random once here and pass it along
            Random random = new Random();

            // Create a test order
            Order testOrder = CreateTestOrder(random);

            // Create a list of orders.
            // This will be passed to the manager pane
            // and serve all required data.
            // In the future this should just be passed to the
            // constructor of this class.
            List<Order> orderList = CreateTestOrderList(random);

            foreach(Order order in orderList)
            {
                Console.WriteLine(order.ToString());

                Panel historyPanel = createHistoryPanel(order);

                // flp stands for flow layout panel.
                // It acts as container for dynamically created panels.
                flpCustomerHistory.Controls.Add(historyPanel);
            };

            return;
            Console.WriteLine("HI Console!");
            string[] items = new string[]
            {
              "Item1, Item02, Item03", "Item2", "Item3", "Item4", "asd", "asd", "asd"
            };

            char[] delimiter1 = new char[] { ',' };
            
            // For each order
            foreach (string item in items)
            {

                string test_time = "17:15 - 18:00";
                string test_date = "01.06.2019";
                int test_table_nr = 5;
                //Panel box = createHistoryPanel(test_time, test_time, test_date, test_table_nr);
                //flpCustomerHistory.Controls.Add(box);

                //Panel panel3 = new System.Windows.Forms.Panel();
                //panel3.BackColor = Color.Red;
                //panel3.Size = new System.Drawing.Size(467, 272);

                ////panel3.SetBounds(0, 0, 300, 300);

                //string[] itemparts = item.Split(delimiter1);
                //Console.WriteLine("itemparts: " + itemparts);
                ////this.textBox1.Text = itemparts[0];

                //ToolStrip toolStrip2 = new ToolStrip();
                //toolStrip2.Items.Add(new ToolStripDropDownButton());
                //toolStrip2.Dock = DockStyle.Bottom;
                //this.Controls.Add(toolStrip2);

                //Button button1 = new System.Windows.Forms.Button();
                //button1.Location = new System.Drawing.Point(258, 380);
                //button1.Name = "button1";
                //button1.Size = new System.Drawing.Size(241, 180);
                //button1.TabIndex = 3;
                //button1.Text = "lolasdasdasdsadsadasdasdasd";
                //button1.UseVisualStyleBackColor = true;
                //this.Controls.Add(button1);

            }
        }

        private List<Order> CreateTestOrderList(Random random)
        {
            List<Order> orderList = new List<Order>();

            // Create 3-12 test orders
            int numberOrders = random.Next(3, 12);

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
            string[] selectedMenus = new string[4];
            for (int i = 0; i <= 3; i++)
            {
                int rndIndex = random.Next(0, allMenuItems.Length);
                selectedMenus[i] = allMenuItems[rndIndex];
            }

            // Provide some test values to create an Order
            // These are later replaced by values from the DB.

            // This is needed to convert strings to DateTime objects.
            CultureInfo dutchFormat = new CultureInfo("nl-NL");

            string randomStartTime = string.Format("01.06.2019 {0:00}:{1:00}", randomHour, randomMinute);
            string randomEndTime = string.Format("01.06.2019 {0:00}:{1:00}", randomHourEnd, randomMinuteEnd);

            Console.WriteLine("RND DATE STRINGS:" + randomStartTime);

            DateTime startTime = Convert.ToDateTime(randomStartTime, dutchFormat);
            DateTime endTime = Convert.ToDateTime(randomEndTime, dutchFormat);

            // A string array of menu items.

            // A dictionary of involved staff members. This could also be simply an array but to be sure to
            // to keep track of the respective professions, a dictionary is used.
            Dictionary<string, string> staff = new Dictionary<string, string>
            {
                { "Cook", "Luigi Marino" },
                { "Waiter", "Anouk Van de Berg" },
                { "Bartender", "Lars Van Dijk" }
            };


            Order order = new Order(startTime, endTime, randomTable, selectedMenus, staff, feedback:"All perfect");

            return order;
        }


        /// <summary>
        /// Setup the manager page
        /// </summary>
        public void setup()
        {
            // Hide detail panels
            //pnlOrderDetails.Hide();
        }

        /// <summary>
        /// Set order values in detail view
        /// </summary>
        public void set_order_values()
        {
            pnlHistory.Show();

            //  for each order of customer:
            // Add order to orderflowcontainer
            // Each menu has a list of ingredients
            // optional wishes are added separately
            
            // Implement a mark order as ready button 


            //throw new NotImplementedException();
        }

        /// <summary>
        /// Make a smooth transition between two panels.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void pageTransition()
        {

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlHistory.Invalidate();
            if (direction == "left")
            {
                pnlHistory.Left -= 10;
                //pnlDetails.Left -= 10;
                //pnlHistory.Location = new Point(pnlHistory.Location.X - 12, pnlHistory.Location.Y);
                //pnlDetails.Location = new Point(pnlDetails.Location.X - 12, pnlDetails.Location.Y);


                if (pnlHistory.Right <= 0)
                {
                    pnlHistory.Refresh();
                    timer1.Stop();
                }
            }
            else
            {
                //pnlDetails.Left += 10;
                pnlHistory.Left += 10;
                //pnlDetails.Location = new Point(pnlDetails.Location.X + 12, pnlDetails.Location.Y);
                //pnlHistory.Location = new Point(pnlHistory.Location.X + 12, pnlHistory.Location.Y);


                //if (pnlHistory.Right >= 350)
                {
                    timer1.Stop();
                }
            }



        }

        /// <summary>
        /// Generate a panel that displays historical order information
        /// </summary>
        /// <param name="time">"17:00-18:30" for example</param>
        /// <param name="date">"03.06.2019" for example</param>
        /// <param name="tableNumber"></param>r
        /// <returns>A panel of histoircal order information</returns>
        private Panel createHistoryPanel(Order order)
        {
            Label lbl_time = new Label();
            lbl_time.Location = new Point(0, 5);
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font(lbl_time.Font, FontStyle.Bold);
            lbl_time.Text = order.Start + "-" + order.End;


            Label lbl_date = new Label();
            lbl_date.Location = new Point(150, 5);
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font(lbl_date.Font, FontStyle.Bold);
            lbl_date.Text = order.Date;

            Label lbl_table = new Label();
            lbl_table.Location = new Point(300, 5);
            lbl_table.AutoSize = true;
            lbl_table.Text = order.Table;


            Button btnOrderDetails = new Button();
            btnOrderDetails.Location = new Point(0, 30);
            btnOrderDetails.Text = "Order Details";
            btnOrderDetails.Size = new Size(364, 30);
            btnOrderDetails.Click += new EventHandler((s, e) => button_Click(s, e, order));

            Button btnAssignedStaff = new Button();
            btnAssignedStaff.Location = new Point(0, 70);
            btnAssignedStaff.Text = "Assigned Staff";
            btnAssignedStaff.Size = new Size(364, 30);
            ////btnAssignedStaff.Click += System.EventHandler(this.showOrder);
            //btnAssignedStaff.Click += delegate { SetStaffValues(); };
            btnAssignedStaff.Click += new EventHandler((s, e) => button_Click(s, e, order));





            Button btnFeedback = new Button();
            btnFeedback.Location = new Point(0, 110);
            btnFeedback.Text = "Customer Feedback";
            btnFeedback.Size = new Size(364, 30);
            btnFeedback.Click += new EventHandler((s, e) => button_Click(s, e, order));

            // Panel that holds all generated UI elements.
            Panel panel_template = new Panel();

            // Add labels to panel
            panel_template.Controls.Add(lbl_time);
            panel_template.Controls.Add(lbl_date);
            panel_template.Controls.Add(lbl_table);

            // Add buttons to panel
            panel_template.Controls.Add(btnOrderDetails);
            panel_template.Controls.Add(btnAssignedStaff);
            panel_template.Controls.Add(btnFeedback);

            // Style panel
            panel_template.BackColor = Color.AliceBlue;
            //panel_template.Name = "panel_template";

            panel_template.Size = new Size(368, 140);
            //panel_template.TabIndex = 3;

            return panel_template;

            //flowContainer.Controls.Add(panel_template);
            //this.Controls.Add(panel_template);
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        /// <summary>
        /// This method is called whenever one of the history view buttons
        /// is pressed. It is determined which information to show on the details page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void button_Click(object sender, EventArgs e, Order order)
        {
            Button button = sender as Button;
            Console.WriteLine("Button with text {0} was clicked", button.Text);

            SetOrderValues(order.Start, order.End, order.Date, order.tableNumber);
            // Set the details pane headline to the text of the button that was clicked
            lblDetailsHeadline.Text = button.Text;

            // Clear all previous elements from details panel
            flpDetails.Controls.Clear();


            direction = "left";
            pageTransition();

            // debug
            string commentMsg = "We found it extremely dope.";

            // Fill the flow layout panel with the required elements.
            if (button.Text == "Order Details")
            {
                flpDetails.Controls.Add(createOrderItemsPanel(order.Menus));
                // Order details

            } else if (button.Text == "Assigned Staff")
            {
                // Staff
                flpDetails.Controls.Add(createAssignedStaffPanel(order.Staff));
            } else if (button.Text  == "Customer Feedback")
            {
                // Feedback
                flpDetails.Controls.Add(CreateCommentPanel(order.Feedback));


            }

        }



        private void SetOrderValues(string startTime, string endTime, string date, int tableNr)
        {
            lblDetailsDate.Text = date;
            lblDetailsTime.Text = startTime + "-" + endTime;
            lblDetailsTable.Text = string.Format("Table {0}", tableNr);
        }

        /// <summary>
        /// Hie the corrent form and display the login form again
        /// </summary>
        private void lblLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
                
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            direction = "right";
            pageTransition();
        }


        /// <summary>
        /// Create a panel that displays a customer's comment
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        private Panel CreateCommentPanel(string msg, string author="Anonymous")
        {
            Panel commentPanel = new Panel
            {
                Size = new Size(375, 75),
                BackColor = Color.Aquamarine
            };

            Label authorName = new Label
            {
                Text = author,
                Font = new Font("Segore UI", 14, FontStyle.Bold),
                AutoSize = true
            };

            Label message = new Label
            {
                Text = msg,
                AutoSize = true,
                Location = new Point(0, 25),


        };

            commentPanel.Controls.Add(authorName);
            commentPanel.Controls.Add(message);

            return commentPanel;
        }

        private Panel createAssignedStaffPanel(Dictionary<string, string> staff)
        {
            Font fontRegular = new Font("Segore UI", 12, FontStyle.Regular);
            Font fontBold = new Font("Segore UI", 14, FontStyle.Bold);

            Panel staffPanel = new Panel
            {
                Font = fontRegular,
                Size = new Size(375, 175),
                BackColor = Color.HotPink
            };

            Label cookHeadline = new Label
            {
                Text = "Cook:",
                Font = fontBold,
                AutoSize = true
            };

            Label cookName = new Label
            {
                Text = staff["Cook"],
                Location = new Point(0, 25),
                BackColor = Color.White,
                AutoSize = true

            };

            Label waiterHeadline = new Label
            {
                Text = "Waiter:",
                Font = fontBold,
                Location = new Point(0, 50),
                AutoSize = true

            };

            Label waiterName = new Label
            {
                Text = staff["Waiter"],
                Location = new Point(0, 75),
                BackColor = Color.White,
                AutoSize = true

            };

            Label bartenderHeadline = new Label
            {
                Text = "Bartender:",
                Font = fontBold,
                Location = new Point(0, 100),
                AutoSize = true

            };

            Label bartenderName = new Label
            {
                Text = staff["Bartender"],
                Location = new Point(0, 125),
                BackColor = Color.White,
                AutoSize = true

            };


            staffPanel.Controls.Add(cookHeadline);
            staffPanel.Controls.Add(cookName);
            staffPanel.Controls.Add(waiterHeadline);
            staffPanel.Controls.Add(waiterName);
            staffPanel.Controls.Add(bartenderHeadline);
            staffPanel.Controls.Add(bartenderName);

            return staffPanel;
        }

        private Panel createOrderItemsPanel(string[] menus)
        {
            Panel itemsPanel = new Panel
            {
                //Font = fontRegular,
                Size = new Size(375, 175),
                BackColor = Color.Yellow,
            };

            ListView itemsView = new ListView
            {
                Size = new Size(375, 175),

            };


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

      
    }
}
