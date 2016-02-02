/*
 * Lorne Roy
 * Student ID 0034514
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06._0_Console_As_Library;
using ClassLibrarySnacks;

namespace VendingMachine
{
    public partial class VendingMachine : Form
    {
        #region constants
        #endregion

        #region private fields

        private CoinBox _coinBoxTransaction;
        private CoinBox _coinBoxLocked;
        private PurchasePrice _sodaPrice;
        private CanRack _canRack;
        private FoodLocker _foodLocker;

        #endregion

        #region properties
        #endregion

        #region contructor

        public VendingMachine()
        {
            
            InitializeComponent();
            _canRack = new CanRack();
            _canRack.FillTheCanRack();
           
            _coinBoxTransaction = new CoinBox();
            _sodaPrice = new PurchasePrice(35);
            labelCredit.Text = String.Format("{0:c}", _coinBoxTransaction.ValueOf);
            labelExactChange.Text = "Exact Change Required";
            labelExactChange.Visible = false;
            labelGeneralMessage.Text = "Welcome";
            buttonLemon.Enabled = false;
            buttonOrange.Enabled = false;
            buttonRegular.Enabled = false;


            //create the locked coin box object
            _coinBoxLocked = new CoinBox();
            //deposit a couple of coins from each denomination in the coinbox to make change
            foreach (Coin.Denomination cn in Coin.AllDenominations)
            {
                for (int i = 0; i < 2; i++)
                {
                    _coinBoxLocked.Deposit(new Coin(cn));
                }
            }

            //create listView for coins in the locked coin box
            initializeCoinBoxDisplay(listViewCoinBoxLocked);
            updateCoinBoxDisplayData(listViewCoinBoxLocked, _coinBoxLocked);


            //create listView for inventory
            initializeInventoryDisplay();
            updateInventoryData();

            _foodLocker = new FoodLocker(10);

            //create listView for snacks
            initializeSnackDisplay();
            updateSnackData();


        }

        #endregion

        #region methods

        private void initializeCoinBoxDisplay(ListView listViewCoinBox)
        {
            listViewCoinBox.Columns.Add("Coin");
            listViewCoinBox.Columns.Add("Quantity");
            listViewCoinBox.Columns.Add("Value");
            //add the items to the listbox.  
            foreach (Coin.Denomination cn in Coin.AllDenominations)
            {
                ListViewItem lvi = new ListViewItem(cn.ToString());
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                listViewCoinBox.Items.Add(lvi);
            }
            ListViewItem coinsTotal = new ListViewItem("Total");
            coinsTotal.SubItems.Add("");
            coinsTotal.SubItems.Add("");


            listViewCoinBox.Items.Add(coinsTotal);
            listViewCoinBox.FullRowSelect = true;
            listViewCoinBox.View = View.Details;
            listViewCoinBox.GridLines = true;

        }

        private void initializeInventoryDisplay()
        {
            listViewInventory.Columns.Add("Flavor");
            listViewInventory.Columns.Add("Quantity");

            //add the flavor items to the listbox.  
            foreach (Flavor _flavor in FlavorOps.AllFlavors)
            {
                ListViewItem lvi = new ListViewItem(_flavor.ToString());
                lvi.SubItems.Add("");
                listViewInventory.Items.Add(lvi);
            }

            //add the totals item to the ListView
            ListViewItem cansTotal = new ListViewItem("Total");
            cansTotal.SubItems.Add("");
            listViewInventory.Items.Add(cansTotal);

            //set listView properties
            listViewInventory.FullRowSelect = true;
            listViewInventory.View = View.Details;
            listViewInventory.GridLines = true;

        }

        private void initializeSnackDisplay()
        {
        }

        private void enoughMoney()
        {
            labelCredit.Text = String.Format("{0:c}", _coinBoxTransaction.ValueOf);

            if (_coinBoxTransaction.ValueOf >= _sodaPrice.PriceDecimal)
            {
                if (_coinBoxLocked.CanMakeChange || (_coinBoxTransaction.ValueOf == _sodaPrice.PriceDecimal))
                {
                    labelExactChange.Visible = false;
                    buttonOrange.Enabled = true;
                    buttonLemon.Enabled = true;
                    buttonRegular.Enabled = true;
                }
                else
                {
                    labelExactChange.Visible = true;
                    buttonOrange.Enabled = false;
                    buttonLemon.Enabled = false;
                    buttonRegular.Enabled = false;
                }
            }
            else
            {
                buttonOrange.Enabled = false;
                buttonLemon.Enabled = false;
                buttonRegular.Enabled = false;
            }
        }

        private void makeChange()
        {
            decimal credit;
            credit = _coinBoxTransaction.ValueOf - _sodaPrice.PriceDecimal;
            _coinBoxTransaction.Transfer(_coinBoxLocked);
            _coinBoxLocked.Transfer(_coinBoxTransaction, credit, true);

        }

        private void checkFlavors()
        {
            if (_canRack.IsEmpty(Flavor.LEMON))
            {
                buttonLemon.Enabled = false;
            }
            if (_canRack.IsEmpty(Flavor.ORANGE))
            {
                buttonOrange.Enabled = false;
            }
            if (_canRack.IsEmpty(Flavor.REGULAR))
            {
                buttonRegular.Enabled = false;
            }

        }

        private void updateSnackData()
        {
            listBoxSnacks.Items.Clear();

            foreach (Snack snack in _foodLocker.Store)
	        {
                listBoxSnacks.Items.Add(snack.Name);
            }
        }


        /// <summary>
        /// update the values in a coin box listView display
        /// </summary>
        /// <param name="listViewCoinBox">the ListView to update</param>
        /// <param name="_coinBox">the CoinBox from which to obtain the data</param>
        private void updateCoinBoxDisplayData(ListView listViewCoinBox, CoinBox _coinBox)
        {
            int i = 0;
            int coinCount = 0;
            foreach (Coin.Denomination cn in Coin.AllDenominations)
            {
                //listViewCoinBox.Items.Find()
                //listViewCoinBox.FindItemWithText(cn.ToString())

                listViewCoinBox.Items[i].SubItems[1].Text = _coinBox.coinCount(cn).ToString();
                coinCount += _coinBox.coinCount(cn);
                listViewCoinBox.Items[i].SubItems[2].Text = string.Format("{0:C}",_coinBox.coinCount(cn) * Coin.ValueOfCoin(cn));
                i++;
            }

            listViewCoinBox.Items[i].SubItems[1].Text = coinCount.ToString();
            listViewCoinBox.Items[i].SubItems[2].Text = string.Format("{0:C}", _coinBox.ValueOf);

        }

        private void updateInventoryData()
        {
            int i = 0;
            int canCount = 0;
            foreach (Flavor _flavor in FlavorOps.AllFlavors)
            {
//                listViewInventory.Items[i].SubItems[1].Text = ;
                i++;
            }

            listViewInventory.Items[i].SubItems[1].Text = canCount.ToString();


        }

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            _coinBoxTransaction.Deposit(Coin.HALFDOLLARCOIN);
            enoughMoney();
            checkFlavors();
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            _coinBoxTransaction.Deposit(Coin.QUARTERCOIN);
            enoughMoney();
            checkFlavors();
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            _coinBoxTransaction.Deposit(Coin.DIMECOIN);
            enoughMoney();
            checkFlavors();
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            _coinBoxTransaction.Deposit(Coin.NICKELCOIN);
            enoughMoney();
            checkFlavors();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            _coinBoxTransaction.Withdraw(_coinBoxTransaction.ValueOf);
            enoughMoney();
        }
        
        private void buttonOrange_Click(object sender, EventArgs e)
        {
            _canRack.RemoveACanOf(Flavor.ORANGE);
            makeChange();
            enoughMoney();
            checkFlavors();
        }

        private void buttonLemon_Click(object sender, EventArgs e)
        {
            _canRack.RemoveACanOf(Flavor.LEMON);
            makeChange();
            enoughMoney();
            checkFlavors();
        }

        private void buttonRegular_Click(object sender, EventArgs e)
        {
            _canRack.RemoveACanOf(Flavor.REGULAR);
            makeChange();
            enoughMoney();
            checkFlavors();

        }

        private void buttonEmptyCoinBox_Click(object sender, EventArgs e)
        {
            _coinBoxLocked.Withdraw(_coinBoxLocked.ValueOf);
            updateCoinBoxDisplayData(listViewCoinBoxLocked, _coinBoxLocked);

        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            _canRack.FillTheCanRack();
        }

        private void tabControlOperationMode_Click(object sender, EventArgs e)
        {
            enoughMoney();
            checkFlavors();
            updateCoinBoxDisplayData(listViewCoinBoxLocked, _coinBoxLocked);
            updateSnackData();
        }

        private void buttonServiceNotes_Click(object sender, EventArgs e)
        {
            FormServiceNotes formServiceNote = new FormServiceNotes();
            formServiceNote.Show();

        }

        private void buttonStockSnacks_Click(object sender, EventArgs e)
        {
            _foodLocker.Stock();
            updateSnackData();
        }


        #endregion

        private void listBoxSnacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSnackDetails.Text = _foodLocker.Store[listBoxSnacks.SelectedIndex].ToString();
        }


    }
}
