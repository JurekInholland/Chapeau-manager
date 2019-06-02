using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
            // hide pnls
            pnlOrderdTable.Hide();
            pnlCurrentOrdersList.Hide();
        }

        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            this.Close();
            login.ShowDialog();
        }

        private void btnTable1_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable1.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable1.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable1.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable1.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable1.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable1.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;

        }

        private void btnTable2_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable2.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable2.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable2.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable2.BackColor = Color.Violet;
            }
            else
            { 
                if (btnTable2.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable2.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable3_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable3.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable3.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable3.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable3.BackColor = Color.Violet;
            }
            else
            {
                if (btnTable3.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable3.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable4_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable4.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable4.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable4.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable4.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable4.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable4.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable5_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable5.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable5.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable5.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable5.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable5.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable5.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable6_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable6.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable6.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable6.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable6.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable6.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable6.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable7_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable7.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable7.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable7.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable7.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable7.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable7.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable8_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable8.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable8.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable8.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable8.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable8.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable8.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable9.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable9.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable9.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable9.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable9.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable9.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/
            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnTable10_Click_1(object sender, EventArgs e)
        {
            //Check / unckeck / Colores
            if (checkBOccupide.Checked)
            {
                btnTable10.BackColor = Color.DarkSeaGreen;
            }
            else if (checkBReserved.Checked)
            {
                btnTable10.BackColor = Color.IndianRed;
            }
            else if (checkBFree.Checked)
            {
                btnTable10.BackColor = Color.White;
            }
            else if (checkBOrdered.Checked)
            {
                btnTable10.BackColor = Color.Violet;
            }
            else
            {                
                if (btnTable10.BackColor == Color.Violet)
                {
                    pnlTablesPlan.Hide();
                    pnlOrderdTable.Show();
                }
                else if (btnTable10.BackColor == Color.DarkSeaGreen)
                {
                    pnlTablesPlan.Hide();
                }
            }
            /*------------------------------*/

            //reset Check boxes
            checkBOccupide.Checked = false;
            checkBReserved.Checked = false;
            checkBFree.Checked = false;
            checkBOrdered.Checked = false;
        }

        private void btnOccupide_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBOccupide.Checked == true)
            {
                checkBOccupide.Checked = false;
            }
            else
            {
                checkBOccupide.Checked = true;
                checkBReserved.Checked = false;
                checkBFree.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnReserved_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBReserved.Checked == true)
            {
                checkBReserved.Checked = false;
            }
            else
            {
                checkBReserved.Checked = true;
                checkBOccupide.Checked = false;
                checkBFree.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnFree_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBFree.Checked == true)
            {
                checkBFree.Checked = false;
            }
            else
            {
                checkBFree.Checked = true;
                checkBOccupide.Checked = false;
                checkBReserved.Checked = false;
                checkBOrdered.Checked = false;
            }
            /*------------------------------*/
        }

        private void btnOrdered_Click_1(object sender, EventArgs e)
        {
            // check / uncheck / reset
            if (checkBOrdered.Checked == true)
            {
                checkBOrdered.Checked = false;
            }
            else
            {
                checkBOrdered.Checked = true;
                checkBOccupide.Checked = false;
                checkBReserved.Checked = false;
                checkBFree.Checked = false;
            }
            /*------------------------------*/
        }

        private void lblBackToPlan_Click(object sender, EventArgs e)
        {
            //Hiding panels
            pnlOrderdTable.Hide();
            pnlTablesPlan.Show();




        }

        private void btnCash_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrentOrder_Click(object sender, EventArgs e)
        {
            pnlOrderdTable.Hide();
            pnlTablesPlan.Hide();
            pnlCurrentOrdersList.Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            pnlOrderdTable.Show();
            pnlTablesPlan.Hide();
            pnlCurrentOrdersList.Hide();
        }
    }
}
