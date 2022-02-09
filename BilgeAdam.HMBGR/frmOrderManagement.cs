using BilgeAdam.Models.Enums;
using BilgeAdam.Models.Models;

namespace BilgeAdam.HMBGR
{
    public partial class frmOrderManagement : Form
    {
        private Dictionary<string, double> PriceList { get; set; }
        private Queue<Order> OrderQueue { get; set; }
        private int orderNo;
        private double totalBalance;

        public frmOrderManagement()
        {
            InitializeComponent();
            InitializePriceList();
            OrderQueue = new Queue<Order>();
            txtBalance.Text = orderNo.ToString();
        }

        private void TmrOrder_Tick(object sender, EventArgs e)
        {
            var tmr = sender as System.Windows.Forms.Timer;
            tmr.Stop();
            var preparedORder = OrderQueue.Dequeue();
            lstReady.Items.Add(preparedORder);
            lstGettingReady.DataSource = OrderQueue.ToList();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTotalPayment.Text = CalculateTotalPayment().ToString();
        }

        private void btnComplateOrder_Click(object sender, EventArgs e)
        {
            orderNo++;
            var order = new Order()
            {
                CustomerName = txtCustomerName.Text,
                Date = DateTime.Now,
                No = orderNo.ToString(),
                Note = txtOrderNote.Text,
                TotalPayment = CalculateTotalPayment(),
                OrderDetail = new OrderDetail()
                {
                    Meat = Enum.Parse<Meat>(GetCheckedRadioButton(grbMeat).Tag.ToString()),
                    Bread = Enum.Parse<Bread>(GetCheckedRadioButton(grbBread).Tag.ToString()),
                    Extras = new HashSet<Extra>(GetExtras<Extra>(grbExtras)),
                    FreeExtras = new HashSet<FreeExtra>(GetExtras<FreeExtra>(grbFreeExtras))
                }
            };
            OrderQueue.Enqueue(order);
            lstGettingReady.DataSource = OrderQueue.ToList();

            GetTimer();

        }
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            if (lstReady.SelectedIndex < 0)
            {
                return;
            }
            var selectedPreparedOrder = lstReady.SelectedItem as Order;
            lstReady.Items.Remove(selectedPreparedOrder);
            totalBalance += selectedPreparedOrder.TotalPayment;
            txtBalance.Text = totalBalance.ToString();
        }

        #region HelperMethods
        private double CalculateTotalPayment()
        {
            var total = 0d;
            var selectedMeat = Enum.Parse<Meat>(GetCheckedRadioButton(grbMeat).Tag.ToString());
            var selectedBread = Enum.Parse<Bread>(GetCheckedRadioButton(grbBread).Tag.ToString());
            var selectedExtras = GetExtras<Extra>(grbExtras);
            total += PriceList[selectedMeat.ToString()];
            total += PriceList[selectedBread.ToString()];
            foreach (var item in selectedExtras)
            {
                total += PriceList[item.ToString()];
            }
            //var selectedFreeExtras = GetFreeExtras(); ücretsiz olduğu için eklenmedi.
            return total;
        }

        private List<T> GetExtras<T>(GroupBox grb) where T : struct, Enum
        {
            var result = new List<T>();
            foreach (var item in grb.Controls)
            {
                var chb = item as CheckBox;
                if (chb.Checked)
                {
                    result.Add(Enum.Parse<T>(chb.Tag.ToString()));
                }
            }
            return result;
        }

        private RadioButton GetCheckedRadioButton(GroupBox grb)
        {
            foreach (var item in grb.Controls)
            {
                var rdb = item as RadioButton;
                if (rdb.Checked) return rdb;
            }
            return null;
        }

        private void InitializePriceList()
        {
            PriceList = new Dictionary<string, double>();
            PriceList.Add("_100", 20);
            PriceList.Add("_150", 27);
            PriceList.Add("_170", 30);
            PriceList.Add("_200", 32);
            PriceList.Add("_250", 40);
            PriceList.Add("Cheese", 7);
            PriceList.Add("Bacon", 12);
            PriceList.Add("White", 10);
            PriceList.Add("Wheat", 12);
        }

        private void GetTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += TmrOrder_Tick;
            timer.Start();
        }



        #endregion
    }
}