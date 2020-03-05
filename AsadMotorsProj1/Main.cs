using AsadMotorsProj1.Entites;
using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Global
/// connection string
/// SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
/// </summary>

namespace AsadMotorsProj1
{
    public partial class Main : Form
    {
        private MembersInfo CMembersInfo = new MembersInfo();
        private string CSEngine, CMPhone, CMName;
        private DateTime CCDate;
        internal delegate void SetDataSourceDelegate(BindingSource bindingSource);
        public Main()
        {
            InitializeComponent();
        }
        private void ResetAll()
        {
            SettingPanel.Hide();
            LoadingLabel.Hide();
            LResetButton.Hide();
            LAddButton.Hide();
            DataGridProgess.Hide();
            ResultText1.Hide();
            MDataGrid.Hide();
            MCDataGrid.Hide();
            SDataGrid.Hide();
            NDataGrid.Hide();
            LMDataGrid.Hide();
            LODataGrid.Hide();
            TSDataGrid.Hide();

            MHelper1.Hide();
            MHelper2.Hide();
            MHelper3.Hide();
            MHelper4.Hide();
            MHelper5.Hide();
            MHelper6.Hide();
            MHelper7.Hide();
            MHelper8.Hide();
            MHelper9.Hide();
            MHelper10.Hide();

            MainTab1.Hide();
            MainTab2.Hide();
            MainTab3.Hide();
            MainTab4.Hide();
            MainTab5.Hide();

            MainTab1.Enabled = true;
            MainTab2.Enabled = true;
            MainTab3.Enabled = true;
            MainTab4.Enabled = true;
            MainTab5.Enabled = true;

            MText1.Hide();
            MText2.Hide();
            MText3.Hide();
            MText4.Hide();
            MText5.Hide();
            MText6.Hide();
            MText7.Hide();
            MText8.Hide();
            MText9.Hide();
            MText10.Hide();

            MainTitleText.Hide();


            MText1.Enabled = true;
            MText2.Enabled = true;
            MText3.Enabled = true;
            MText4.Enabled = true;
            MText5.Enabled = true;
            MText6.Enabled = true;
            MText7.Enabled = true;
            MText8.Enabled = true;
            MText9.Enabled = true;
            MText10.Enabled = true;


            MText1.Text = "";
            MText2.Text = "";
            MText3.Text = "";
            MText4.Text = "";
            MText5.Text = "";
            MText6.Text = "";
            MText7.Text = "";
            MText8.Text = "";
            MText9.Text = "";
            MText10.Text = "";


            MLabel1.Hide();
            MLabel2.Hide();
            MLabel3.Hide();
            MLabel4.Hide();
            MLabel5.Hide();
            MLabel6.Hide();
            MLabel7.Hide();
            MLabel8.Hide();
            MLabel9.Hide();
            MLabel10.Hide();

            MComboBox1.Hide();
            MComboBox2.Hide();

            MComboBox1.Enabled = true;
            MComboBox2.Enabled = true;

            MComboBox1.Text = "Select";
            MComboBox2.Text = "Select";

            MAddButton.Hide();
            MResetButton.Hide();

            NAddButton.Hide();
            NResetButton.Hide();

            MSearchButton.Hide();
            MSearchButton2.Hide();

            SResetButton.Hide();
            SAddButton.Hide();

            MRichText1.Hide();
            MCheck1.Hide();
            MCheck2.Hide();

            MRichText1.Enabled = true;
            MCheck1.Enabled = true;
            MCheck2.Enabled = true;

            MRichText1.Text = "";
            MCheck1.Checked = false;
            MCheck2.Checked = false;

            SResetButton.Hide();
            SAddButton.Hide();

            MUpdate1.Hide();
            MUpdate2.Hide();
            MUpdate3.Hide();
            MUpdate4.Hide();
            MUpdate5.Hide();
            MUpdate6.Hide();
            MUpdate7.Hide();
            MUpdate8.Hide();
            MUpdate9.Hide();
            MUpdate10.Hide();


        }
        private void ShowExpensesItems()
        {
            MText1.Show();
            MLabel1.Show();
            MLabel1.Text = "Amount";
            MLabel2.Show();
            MRichText1.Show();
            MLabel2.Text = "Description";
            MLabel4.Show();
            MText4.Show();
            MLabel4.Text = "Date";

            MAddButton.Show();
        }
        private void HideUpdate4()
        {
            MUpdate1.Hide();
            MUpdate2.Hide();
            MUpdate3.Hide();
            MUpdate4.Hide();
        }
        private void ShowUpdate4()
        {
            MUpdate1.Show();
            MUpdate2.Show();
            MUpdate3.Show();
            MUpdate4.Show();
        }
        private void HideExpensesItems()
        {
            MText1.Hide();
            MLabel1.Hide();
            MRichText1.Hide();
            MLabel2.Hide();
            MLabel3.Hide();
            MText3.Hide();

            MAddButton.Hide();
        }
        private void HideCheckItems2()
        {
            HideCheckItems();
            MSearchButton2.Hide();
            MComboBox1.Hide();

        }
        private void ShowCheckItems2()
        {
            ShowCheckItems();
            MSearchButton.Hide();
            MText1.Hide();
            MSearchButton2.Show();
            MComboBox1.Show();

        }
        private void HideNetSellingItems()
        {
            // Hiding Texts

            MText1.Hide();
            MText2.Hide();
            MText3.Hide();
            MText4.Hide();
            MText5.Hide();
            MText6.Hide();
            MText7.Hide();

            // Hiding Labels

            MLabel1.Hide();
            MLabel2.Hide();
            MLabel3.Hide();
            MLabel4.Hide();
            MLabel5.Hide();
            MLabel6.Hide();
            MLabel7.Hide();

            // Hiding Buttons

            NAddButton.Hide();
            NResetButton.Hide();
        }
        private void ShowNetSellingItems()
        {
            // Hiding Texts

            MText1.Show();
            MText1.MaxLength = 15;
            MText2.Show();
            MText2.MaxLength = 25;
            MText3.Show();
            MText3.MaxLength = 100;
            MText4.Show();
            MText4.MaxLength = 11;
            MText5.Show();
            MText5.MaxLength = 50;
            MText6.Show();
            MText6.MaxLength = 6;
            MText7.Show();
            MText7.MaxLength = 10;

            MLabel1.Text = "CNIC";
            MLabel2.Text = "Name";
            MLabel3.Text = "Address";
            MLabel4.Text = "Phone";
            MLabel5.Text = "Engine No.";
            MLabel6.Text = "Amount";
            MLabel7.Text = "Date";


            // Hiding Labels

            MLabel1.Show();
            MLabel2.Show();
            MLabel3.Show();
            MLabel4.Show();
            MLabel5.Show();
            MLabel6.Show();
            MLabel7.Show();

            // Hiding Buttons

            NAddButton.Show();
            NAddButton.Text = "Check Out";
            NResetButton.Show();
        }
        private void HideUpdate3()
        {
            MUpdate1.Hide();
            MUpdate2.Hide();
            MUpdate3.Hide();
            MUpdate4.Hide();
            MUpdate5.Hide();
            MUpdate6.Hide();
        }
        private void ShowUpdate3()
        {
            MUpdate1.Show();
            MUpdate2.Show();
            MUpdate3.Show();
            MUpdate4.Show();
            MUpdate5.Show();
            MUpdate6.Show();
            MUpdate7.Show();
        }
        private void HideStockItems()
        {
            // Hiding Labels

            MLabel1.Hide();
            MLabel2.Hide();
            MLabel3.Hide();
            MLabel4.Hide();
            MLabel5.Hide();
            MLabel6.Hide();
            MLabel7.Hide();
            MLabel8.Hide();
            MLabel9.Hide();
            MLabel10.Hide();

            // Hiding Text Boxes

            MText1.Hide();
            MText2.Hide();
            MText3.Hide();
            MText4.Hide();
            MText5.Hide();
            MText6.Hide();
            MText7.Hide();
            MText8.Hide();

            // Hiding Check Boxes and Buttons

            SResetButton.Hide();
            SAddButton.Hide();
            MCheck1.Hide();
            MCheck2.Hide();

        }
        private void ShowStockItems()
        {
            // Showing Labels

            MLabel1.Show();
            MLabel2.Show();
            MLabel3.Show();
            MLabel4.Show();
            MLabel5.Show();
            MLabel6.Show();
            MLabel7.Show();
            MLabel8.Show();
            MLabel9.Show();
            MLabel10.Show();

            // Showing Text Boxes and Change Label Text

            MText1.Show();
            MLabel1.Text = "Engine No.";
            MText2.Show();
            MLabel2.Text = "Chassis No.";
            MText3.Show();
            MLabel3.Text = "Company";
            MText4.Show();
            MLabel4.Text = "Model";
            MText5.Show();
            MLabel5.Text = "Amount";
            MText6.Show();
            MLabel6.Text = "Reg. No.";
            MText7.Show();
            MLabel7.Text = "File No.";
            MText8.Show();
            MLabel8.Text = "Date";

            MLabel9.Text = "Copy Recived";
            MLabel10.Text = "Letter Recived";

            // Showing Check Boxes and Buttons

            SResetButton.Show();
            SAddButton.Show();
            MCheck1.Show();
            MCheck2.Show();

        }
        private void HideUpdate2()
        {
            MUpdate1.Hide();
            MUpdate2.Hide();
            MUpdate3.Hide();
            MUpdate4.Hide();
            MUpdate5.Hide();
            MUpdate6.Hide();
            MUpdate7.Hide();
            MUpdate8.Hide();
            MUpdate9.Hide();
            MUpdate10.Hide();

        }
        private void ShowUpdate2()
        {
            MUpdate1.Show();
            MText1.Enabled = false;
            MUpdate2.Show();
            MText2.Enabled = false;
            MUpdate3.Show();
            MText3.Enabled = false;
            MUpdate4.Show();
            MText4.Enabled = false;
            MUpdate5.Show();
            MText5.Enabled = false;
            MUpdate6.Show();
            MText6.Enabled = false;
            MUpdate7.Show();
            MText7.Enabled = false;
            MUpdate8.Show();
            MText8.Enabled = false;
            MUpdate9.Show();
            MText9.Enabled = false;
            MUpdate10.Show();
            MText10.Enabled = false;

        }
        private void ControlDisable()
        {
            BMembersInfo.Enabled = false;
            BCommitteeEntry.Enabled = false;
            BTracking.Enabled = false;
            BLeasing.Enabled = false;
            BNetSelling.Enabled = false;
            BManagement.Enabled = false;
            BStock.Enabled = false;
            BInstallment.Enabled = false;
        }
        private void HideCheckItems()
        {
            MLabel1.Hide();
            MText1.Hide();
            MSearchButton.Hide();
        }
        private void ShowCheckItems()
        {
            MLabel1.Show();
            MLabel1.Text = "CNIC";
            MText1.Show();
            MSearchButton.Show();
        }
        private void HideUpdateLabels()
        {
            MUpdate1.Hide();
            MUpdate3.Hide();
            MUpdate2.Hide();
            MUpdate4.Hide();

        }
        private void ShowUpdatelabels()
        {
            MUpdate1.Show();
            MUpdate2.Show();
            MUpdate3.Show();
            MUpdate4.Show();
            MSearchButton.Show();
        }
        private void HideMemberItems()
        {
            // Hiding member items

            MLabel1.Hide();
            MText1.Hide();
            MText3.Hide();
            MLabel2.Hide();
            MText2.Hide();
            MText3.Hide();
            MLabel3.Hide();
            MLabel4.Hide();
            MText4.Hide();
            MResetButton.Hide();
            MAddButton.Hide();

        }
        private void ShowMemberItems()
        {
            MLabel1.Show();
            MText1.Show();
            MLabel1.Text = "CNIC";
            MText2.Show();
            MLabel2.Text = "Name";
            MLabel2.Show();
            MText3.Show();
            MLabel3.Text = "Address";
            MLabel3.Show();
            MLabel4.Show();
            MLabel4.Text = "Phone";
            MText4.Show();
            MResetButton.Show();
            MAddButton.Show();
        }
        private void Admin()
        {
            BMembersInfo.Enabled = true;
            BCommitteeEntry.Enabled = true;
            BTracking.Enabled = true;
            BLeasing.Enabled = true;
            BNetSelling.Enabled = true;
            BManagement.Enabled = true;
            BStock.Enabled = true;
            BInstallment.Enabled = true;
        }
        private void LocalUser()
        {
            BMembersInfo.Enabled = false;
            BCommitteeEntry.Enabled = true;
            BTracking.Enabled = false;
            BLeasing.Enabled = false;
            BNetSelling.Enabled = false;
            BManagement.Enabled = false;
            BStock.Enabled = false;
            BInstallment.Enabled = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ResetAll();

            // Panels to hide on Load Main Window

            Installment_Panel.Hide();
            MSearchButton.Hide();
            MUpdate1.Hide();
            HideCheckItems();
            HideMemberItems();
            HideUpdateLabels();
            NetSelling_Panel.Hide();
            Leasing_Panel.Hide();
            Stock_Panel.Hide();
            Tracking_Panel.Hide();
            CommitteeEntry_Panel.Hide();
            Main_Panel.Show();
            Member_Panel.Hide();
            ManageBudget_Panel.Hide();
            HideStockItems();
            HideNetSellingItems();
            HideUpdate2();
            HideExpensesItems();
            HideUpdate4();
            HideCheckItems2();
            MComboBox2.Hide();

            // Date getter

            Date.Text = DateTime.Now.ToLongDateString();

            // Tab Setting

            MainTab1.Enabled = false;
            MainTab2.Enabled = false;
            MainTab3.Enabled = false;
            MainTab4.Enabled = false;
            MainTab5.Enabled = false;


            // Tab Setting

            //MainTab1.Text = "Login";
            //MainTab1.selected = true;
            //MainTab2.Enabled = true;
            //Main_Running_Control.Text = "Authentication";

            //Login Items

            //MLabel3.Show();
            //MLabel4.Show();
            //MText3.Show();
            //MText4.Show();
            //MLabel3.Text = "Username";
            //MLabel4.Text = "Password";
            //MAddButton.Show();
            //MAddButton.Text = "Login";
            //ControlDisable();

            MDataGrid.BorderStyle = BorderStyle.None;
            MDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230); ;
            MDataGrid.RowsDefaultCellStyle.BackColor = Color.LightGray;
            MDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MDataGrid.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            MDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            MDataGrid.BackgroundColor = Color.White;
            MDataGrid.DefaultCellStyle.Font = new Font("Arial", 18F, GraphicsUnit.Pixel);
            MDataGrid.EnableHeadersVisualStyles = false;
            MDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            MDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 22F, GraphicsUnit.Pixel);
            MDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            MDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }
        private void BMembersInfo_Click(object sender, EventArgs e)
        {
            // Panels to show and hide for Member'sInfo Control
            Installment_Panel.Hide();
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Leasing_Panel.Hide();
            Tracking_Panel.Hide();
            CommitteeEntry_Panel.Hide();
            Member_Panel.Visible = false;
            bunifuTransition1.ShowSync(Member_Panel);

            // Sub menu selected to false

            BNewMember.selected = false;
            BDeleteMember.selected = false;
            BUpdateMember.selected = false;
            BShowMInfo.selected = false;
        }
        private void BCommitteeEntry_Click(object sender, EventArgs e)
        {
            // Panels to show and hide for Committee Enter Control
            Installment_Panel.Hide();
            ManageBudget_Panel.Hide();
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Leasing_Panel.Hide();
            Tracking_Panel.Hide();
            Member_Panel.Hide();
            CommitteeEntry_Panel.Show();

            // Sub menu selected to false

            BEnterCommittee.selected = false;
            BModifyCommittee.selected = false;
        }
        private void BTracking_Click(object sender, EventArgs e)
        {
            // Panels to show and hide for Tracking Control
            Installment_Panel.Hide();
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Leasing_Panel.Hide();
            Tracking_Panel.Show();
            Member_Panel.Hide();
            CommitteeEntry_Panel.Hide();

            // Sub menu selected to false

            BMember.selected = false;
            BDaily.selected = false;
            BMonthly.selected = false;

        }
        private void BLeasing_Click(object sender, EventArgs e)
        {
            // Panels to show and hide for Leasing Control
            Installment_Panel.Hide();
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Leasing_Panel.Show();
            Tracking_Panel.Hide();
            Member_Panel.Hide();

            // Sub menu seleted to false

            BNewLease.selected = false;
            BDeleteLease.selected = false;
            BUpdateLease.selected = false;
            BShowLInfo.selected = false;
        }
        private void Dash_Click(object sender, EventArgs e)
        {
            // Panels to hide when click on random place
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Leasing_Panel.Hide();
            Tracking_Panel.Hide();
            Member_Panel.Hide();
            CommitteeEntry_Panel.Hide();
        }
        private void MainTab1_Click(object sender, EventArgs e)
        {
            if (MainTab1.Text == "Daily Total")
            {
                MLabel1.Text = "Date";
                MHelper1.Text = "eg. dd/mm/yy";
            }
            if (MainTab1.Text == "Date Wise")
            {
                BMember_Click(BMember, EventArgs.Empty);
            }
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                BUpdateLease_Click(BUpdateLease, EventArgs.Empty);
            }
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                BUpdateLease_Click(BUpdateLease, EventArgs.Empty);
                Main_Running_Control.Text = " -   ( Delete lease information )";
            }
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Enter new lease information )")
            {
                BNewLease_Click(BNewLease, EventArgs.Empty);
            }
            if (MainTab1.Text == "Check Specific Record")
            {
                BCheck_Click(BCheck, EventArgs.Empty);
            }
            if (MainTab1.Text == "Check Specific Member")
            {
                BShowMInfo_Click(BShowMInfo, EventArgs.Empty);
            }
            if (MainTab1.Text == "Check Specific Customer")
            {
                BShowLInfo_Click(BShowLInfo, EventArgs.Empty);
            }
            if (MainTab1.Text == "Check Member Lease")
            {
                BShowInformation_Click(BShowInformation, EventArgs.Empty);
                MainTab1.Text = "Check Member Lease";
                Main_Running_Control.Text = " -   ( Show lease information )";
                MainTab2.Text = "All Member Leases";
                MainTab3.Show();
                MainTab4.Show();
            }
            if (MainTab1.Text == "Adding")
            {
                BAddExpenses_Click(BAddExpenses, EventArgs.Empty);
            }
            if (MainTab1.Text == "Update" & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {
                BModifyCommittee_Click(BModifyCommittee, EventArgs.Empty);
            }
            if (MainTab1.Text == "Update" & Main_Running_Control.Text == " -   ( Modify Installment Entry )")
            {
                BIModify_Click(BIModify, EventArgs.Empty);
            }
            if (MainTab1.Text == "Delete")
            {
                Main_Running_Control.Text = "Delete Committee Entry";
            }
        }
        private void BNewMember_Click(object sender, EventArgs e)
        {
            ResetAll();
            HideNetSellingItems();

            //Panel to hide for New Member Control

            MComboBox2.Hide();
            HideStockItems();
            Member_Panel.Hide();
            MSearchButton2.Hide();
            MComboBox1.Hide();
            MainTab1.Hide();


            //Tab settings for New Member Control

            MainTab1.Show();
            MainTab1.Text = BNewMember.Text;
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            //Tab settings for New Member Control

            MainTab2.Show();
            MainTab2.Text = "Lucky Member";
            MainTab2.Enabled = true;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;


            // Header name for the New Member Control 

            Main_Running_Control.Text = " -   ( Enter new member's information )";
            MAddButton.Show();
            MAddButton.Text = "Add";
            Main_Running_Control.Show();

            // Showing member items

            ShowMemberItems();
            MSearchButton.Hide();

            // Hiding Update Labels
            HideUpdateLabels();

            // Enable Text Boxes

            MText1.Enabled = true;
            MText1.MaxLength = 15;
            MText2.Enabled = true;
            MText2.MaxLength = 25;
            MText3.Enabled = true;
            MText3.MaxLength = 100;
            MText4.Enabled = true;
            MText4.MaxLength = 11;

        }
        private void BUpdateMember_Click(object sender, EventArgs e)
        {
            ResetAll();
            // Panels to show and hide 

            Member_Panel.Hide();
            Main_Running_Control.Text = " -   ( Update Member's Information )";
            MainTab1.Show();
            MainTab1.Text = BUpdateMember.Text;
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Showing Check Items
            MLabel1.Show();
            ShowCheckItems();

            MSearchButton.Hide();
            MSearchButton2.Show();

            MLabel2.Show();
            MLabel1.Text = "Phone";
            MLabel2.Text = "Name";
            MText1.MaxLength = 11;
            MText2.MaxLength = 25;
            MText2.Show();
            MText1.Enabled = true;
            MHelper1.Show();
            MHelper2.Show();
            MHelper1.Text = "eg. 03001234567";
            MHelper2.Text = "eg. Hussain Ali";
        }
        private void Check_Click(object sender, EventArgs e)
        {


            // If the check is for Delete Member

            if (MainTab1.Text == BDeleteMember.Text)
            {


            }

            // If the check is Show Member Information

            if (MainTab1.Text == BShowLInfo.Text)
            {

            }

            // Showing updates control for each information if it is Update module

            if (MainTab1.Text == BUpdateMember.Text)
            {

            }
        }
        private void BDeleteMember_Click(object sender, EventArgs e)
        {
            ResetAll();
            BUpdateMember_Click(BUpdateMember, EventArgs.Empty);
            // Panels to hide or show for Delete Member Control

            Member_Panel.Hide();

            // Header text for Delete Member Control

            Main_Running_Control.Text = " -   ( Delete Member's Information )";

            // Tab setting for Delete Member Control

            MainTab1.Show();
            MainTab1.Text = BDeleteMember.Text;
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;


            // Showing Check Items

            MLabel1.Show();
            ShowCheckItems();

            MSearchButton.Hide();
            MSearchButton2.Show();
            MLabel2.Show();
            MLabel2.Text = "Name";
            MLabel1.Text = "Phone";
            MText2.Show();
            MText1.Enabled = true;
            MHelper1.Show();
            MHelper2.Show();
            MHelper1.Text = "eg. 03001234567";
            MHelper2.Text = "eg. Hussain Ali";
        }
        private void BShowMInfo_Click(object sender, EventArgs e)
        {
            ResetAll();
            BUpdateMember_Click(BUpdateMember, EventArgs.Empty);
            // Header text for Show Member's  Information Control

            Main_Running_Control.Text = " -   ( Show Member's Information )";
            // Tab Setting for Modify Committee Control
            MainTab1.Show();
            MainTab2.Show();
            MainTab1.Text = "Check Specific Member";
            MainTab2.Text = "Check All Members";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;


            MLabel2.Show();
            MLabel1.Text = "Phone";
            MLabel2.Text = "Name";
            MText2.Show();
            MText1.Enabled = true;
            MText1.Enabled = true;
            MHelper1.Show();
            MHelper2.Show();
            MHelper1.Text = "eg. 03001234567";
            MHelper2.Text = "eg. Hussain Ali";

        }
        private void BEnterCommittee_Click(object sender, EventArgs e)
        {

            // Main Tab Text Setting
            ResetAll();
            MainTab1.Show();
            Main_Running_Control.Text = " -   ( Committee Entry )";
            Main_Running_Control.Show();
            MainTab1.Text = BEnterCommittee.Text;
            MainTab1.Enabled = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab1.selected = true;

            // Things to Hide for Committe Enter Control

            CommitteeEntry_Panel.Hide();
            Tracking_Panel.Hide();
            Main_Running_Control.Show();

            // Showing Contents

            MLabel1.Show();
            MLabel2.Show();
            MLabel3.Show();
            MLabel4.Show();
            MLabel1.Text = "Phone *";
            MHelper1.Text = "eg. 03001212121";
            MLabel2.Text = "Name *";
            MHelper2.Text = "eg. Hussain Ali";
            MLabel3.Text = "Type";
            MLabel4.Text = "Date *";
            MHelper4.Text = "eg. mm/dd/yyyy";
            MHelper1.Show();
            MHelper2.Show();
            MHelper4.Show();
            MText1.Show();
            MText4.Show();
            MText4.Enabled = true;
            MText1.Enabled = true;
            MText2.Enabled = true;
            MComboBox2.Enabled = true;
            MText2.Show();
            MComboBox2.Show();
            MAddButton.Text = "Add";
            MAddButton.Show();
            MResetButton.Show();
            MResetButton.Text = "Reset";
            MainTab1.Show();
            MText1.MaxLength = 11;
            MText2.MaxLength = 25;
            MText4.MaxLength = 10;


        }
        private void BDaily_Click(object sender, EventArgs e)
        {
            ResetAll();

            // Things to show and hide for Daily Tracking Control

            Tracking_Panel.Hide();
            Main_Running_Control.Hide();
            Main_Running_Control.Show();

            // Tab Setting for Track Daily Control

            MainTab1.Show();
            MainTab1.Text = BDaily.Text;
            MainTab1.Enabled = true;
            MainTab1.selected = true;


            // Undo effects
            Main_Running_Control.Text = " -   ( Track Daily Amount )";
            Main_Running_Control.Show();

            MLabel1.Show();
            MHelper1.Show();
            MHelper1.Text = "eg. dd/mm/yy";
            MLabel1.Text = "Date";
            MText1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Check";

        }
        private void BModifyCommittee_Click(object sender, EventArgs e)
        {
            ResetAll();
            // Tab Setting for Modify Committee Control

            MainTab1.Show();
            MainTab2.Show();
            MainTab1.Text = "Update";
            MainTab2.Text = "Delete";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Header Text

            Main_Running_Control.Text = " -   ( Modify Committee Entry )";

            // Panels to show or hide

            CommitteeEntry_Panel.Hide();

            // Showing Contents

            MLabel1.Show();
            MLabel2.Show();
            MLabel3.Show();

            MLabel1.Text = "Phone *";
            MLabel2.Text = "Name *";
            MLabel3.Text = "Date *";

            MHelper1.Show();
            MHelper2.Show();
            MHelper3.Show();

            MHelper1.Text = "eg. 03001122334";
            MHelper2.Text = "eg. Hussain Ali";
            MHelper3.Text = "eg. dd/mm/yy";
            MText1.Show();
            MText2.Show();
            MText3.Show();

            MText1.Enabled = true;
            MText2.Enabled = true;
            MText3.Enabled = true;

            MText1.MaxLength = 11;
            MText2.MaxLength = 25;
            MText3.MaxLength = 10;

            MResetButton.Show();
            MResetButton.Text = "Search";
        }
        private void MainTab2_Click(object sender, EventArgs e)
        {
            if (MainTab2.Text == "Lucky Member" & MainTab2.selected == true)
            {

            }
            if (MainTab2.Text == "For Outsider"
                & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                BUpdateLease_Click(BUpdateLease, EventArgs.Empty);
                Main_Running_Control.Text = " -   ( Delete lease information )";
            }
            if (MainTab2.Text == "Monthly Total")
            {
                MLabel1.Text = "Month";
                MHelper1.Text = "mm/yy";
            }
            if (MainTab2.Text == "Month Wise")
            {
                MText1.MaxLength = 11;
                MText2.MaxLength = 25;
                MText3.MaxLength = 7;
                MText1.Show();
                MLabel1.Show();
                MHelper1.Show();
                MHelper1.Text = "eg. 03003333333";
                MLabel1.Text = "Phone";
                MLabel2.Text = "Name";
                MLabel3.Text = "Month";
                MLabel3.Show();
                MHelper2.Text = "eg. Hussain Ali";
                MText3.Show();
                MHelper3.Show();
                MHelper3.Text = "eg. mm/yy";
                MLabel2.Show();
                MHelper2.Show();
                MText2.Show();
                MSearchButton2.Hide();
                MResetButton.Show();
                MResetButton.Text = "Search";
            }
            if (MainTab2.Text == "For Outsider" & Main_Running_Control.Text == " -   ( Enter new lease information )")
            {
                BNewCustomer_Click(BNewCustomer, EventArgs.Empty);
                MainTab1.Text = "For Member";
                MLabel6.Text = "Advance";
                MLabel7.Text = "Amount";
                MLabel8.Text = "Duration";
                MLabel9.Text = "Installment";
                MLabel10.Text = "Date";
                MLabel8.Show();
                MLabel9.Show();
                MLabel10.Show();
                MText8.Show();
                MText9.Show();
                MText10.Show();
                Main_Running_Control.Text = " -   ( Enter new lease information )";
                MainTab2.Show();
                NResetButton.Hide();
                NAddButton.Hide();
                SResetButton.Show();
                SAddButton.Show();
                SAddButton.Text = "Check Out";
                MText1.MaxLength = 15;
                MText2.MaxLength = 25;
                MText3.MaxLength = 100;
                MText4.MaxLength = 11;
                MText5.MaxLength = 50;
                MText6.MaxLength = 5;
                MText7.MaxLength = 5;
                MText8.MaxLength = 2;
                MText9.MaxLength = 5;
                MText10.MaxLength = 10;

                MHelper1.Text = "eg. 11111-1111111-1";
                MHelper2.Text = "eg. Hussain Ali";
                MHelper4.Text = "eg. 03001212120";
                MHelper8.Text = "in month";
                MHelper10.Text = "eg. dd/mm/yyyy";

                MHelper1.Show();
                MHelper2.Show();
                MHelper4.Show();
                MHelper8.Show();
                MHelper10.Show();


            }
            if (MainTab2.Text == "For Outsider" & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                BUpdateLease_Click(BUpdateLease, EventArgs.Empty);
            }
            if (MainTab2.Text == "Check All Members")
            {
                ResetAll();
                MainTab1.Show();
                MainTab2.Show();
                MLabel1.Show();
                MSearchButton.Show();
                MLabel1.Text = "If you click check button then all information of all members will show.";
                MText1.Hide();
                MSearchButton.Text = "Check";
            }
            if (MainTab2.Text == "Check All Records")
            {
                ResetAll();
                MainTab1.Show();
                MainTab2.Show();
                MLabel1.Show();
                MSearchButton.Show();
                MLabel1.Text = "If you click check button then all information of all records will show.";
                MSearchButton.Text = "Check";
            }
            if (MainTab2.Text == "All Member Leases")
            {
                ResetAll();
                MainTab3.Show();
                MainTab4.Show();
                MainTab1.Show();
                MainTab2.Show();
                MLabel1.Show();
                MSearchButton.Show();
                MLabel1.Text = "If you click check button then all information of all leases will show.";
                MText1.Hide();
                MSearchButton.Text = "Check";
            }
            if (MainTab2.Text == "Check All Customers")
            {
                ResetAll();
                MainTab1.Show();
                MainTab2.Show();
                MLabel1.Show();
                MSearchButton.Show();
                MLabel1.Text = "If you click check button then all information of all customers will show.";
                MText1.Hide();
                MSearchButton.Text = "Check";
            }
            if (MainTab2.Text == "Show")
            {
                ShowCheckItems();
                MText1.Hide();
                MSearchButton.Hide();
                MText2.Hide();
                MRichText1.Hide();
                MLabel2.Hide();
                MLabel4.Hide();
                MText4.Hide();
                MAddButton.Hide();
                MSearchButton2.Hide();

                MLabel1.Text = "Type";
                MComboBox1.Show();

            }
            if (MainTab2.Text == "Delete" & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {
                BModifyCommittee_Click(BModifyCommittee, EventArgs.Empty);
                MainTab2.selected = true;
            }
            if (MainTab2.Text == "Delete" & Main_Running_Control.Text == " -   ( Modify Installment Entry )")
            {
                BIModify_Click(BIModify, EventArgs.Empty);
            }
            if (MainTab2.Text == "Monthly")
            {
            }
        }
        private void BStock_Click(object sender, EventArgs e)
        {
            // Panels to show or hide
            Installment_Panel.Hide();
            NetSelling_Panel.Hide();
            CommitteeEntry_Panel.Hide();
            Tracking_Panel.Hide();
            Leasing_Panel.Hide();
            Member_Panel.Hide();
            Stock_Panel.Show();
            ManageBudget_Panel.Hide();

        }
        private void BManageBudget_Click(object sender, EventArgs e)
        {
            Installment_Panel.Hide();
            NetSelling_Panel.Hide();
            CommitteeEntry_Panel.Hide();
            Tracking_Panel.Hide();
            Leasing_Panel.Hide();
            Member_Panel.Hide();
            Stock_Panel.Hide();
            ManageBudget_Panel.Show();
        }
        private void BSetting_Click(object sender, EventArgs e)
        {
            Installment_Panel.Show();
            NetSelling_Panel.Hide();
            CommitteeEntry_Panel.Hide();
            Tracking_Panel.Hide();
            Leasing_Panel.Hide();
            Member_Panel.Hide();
            Stock_Panel.Hide();
            ManageBudget_Panel.Hide();

        }
        private void BNetSelling_Click(object sender, EventArgs e)
        {
            Installment_Panel.Hide();
            NetSelling_Panel.Show();
            CommitteeEntry_Panel.Hide();
            Tracking_Panel.Hide();
            Leasing_Panel.Hide();
            Member_Panel.Hide();
            Stock_Panel.Hide();
            ManageBudget_Panel.Hide();
        }
        private void BMonthly_Click(object sender, EventArgs e)
        {
            ResetAll();
            // Things to show and hide for Daily Tracking Control

            Tracking_Panel.Hide();
            Main_Running_Control.Hide();
            Main_Running_Control.Show();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = BMonthly.Text;
            MainTab1.Enabled = false;
            MainTab1.selected = false;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Undo effects
            Main_Running_Control.Text = " -   ( Track Monthly Amount )";
            Main_Running_Control.Show();

            MText1.Show();
            MHelper1.Text = "eg. 01/2000";
            MHelper1.Show();
            MLabel1.Text = "Month";
            MLabel1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Check";
        }
        private void BMember_Click(object sender, EventArgs e)
        {
            ResetAll();
            MText1.MaxLength = 11;
            MText2.MaxLength = 25;
            MText3.MaxLength = 10;

            // Things to show and hide for Daily Tracking Control

            Tracking_Panel.Hide();
            Main_Running_Control.Hide();
            Main_Running_Control.Show();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = "Date Wise";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            MainTab2.Show();
            MainTab2.Text = "Month Wise";
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            MainTab3.Show();
            MainTab3.Text = "Total";
            MainTab3.Enabled = true;
            MainTab3.selected = false;
            MainTab3.BorderStyle = BorderStyle.Fixed3D;

            // Undo effects
            Main_Running_Control.Text = " -   ( Track Member Committee )";
            Main_Running_Control.Show();

            MText1.Show();
            MLabel1.Show();
            MHelper1.Show();
            MHelper1.Text = "eg. 03004599898";
            MLabel1.Text = "Phone";
            MLabel2.Text = "Name";
            MLabel3.Show();
            MLabel3.Text = "Date";

            MHelper3.Text = "eg. dd/mm/yy";
            MHelper2.Text = "eg. Hussain Ali";
            MLabel2.Show();
            MHelper2.Show();
            MHelper3.Show();
            MText2.Show();
            MResetButton.Show();
            MResetButton.Text = "Search";
            MText3.Show();

        }
        private void MResetButton_Click(object sender, EventArgs e)
        {
            if (MainTab3.Text == "Total" & MainTab3.selected == true)
            {
                MainTab3_Click(MainTab3, EventArgs.Empty);
            }
            if (MainTab2.Text == "Month Wise"
                & MainTab2.selected == true
                & Main_Running_Control.Text == " -   ( Track Member Committee )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone is not in valid formate.");
                    return;
                }
                if (MText2.TextLength == 0)
                {
                    MessageBox.Show("Name must be required.");
                    return;
                }
                if (MText3.TextLength == 0)
                {
                    MessageBox.Show("Month must be required.");
                    return;
                }
                if (MText3.Text.Substring(0, 3).Substring(2) != "/")
                {
                    MessageBox.Show("Month and Year should be in this formate \"01/2000\"");
                    return;
                }
                SQLHelpers sQLHelpers = new SQLHelpers();
                MAddButton.Hide();
                MResetButton.Hide();
                MLabel1.Hide();
                MText1.Hide();
                MHelper1.Hide();
                MLabel2.Hide();
                MText2.Hide();
                MHelper2.Hide();
                MText3.Hide();
                MLabel3.Hide();
                MHelper3.Hide();

                MDataGrid.DataSource = sQLHelpers.GetMCommitteeMonthWise(MText1.Text.ToString(), MText2.Text.ToString(), MText3.Text.Substring(0, 2), MText3.Text.Substring(3));
                var dres = sQLHelpers.GetMCommitteeSumMonthWise(MText1.Text.ToString(), MText2.Text.ToString(), MText3.Text.Substring(0, 2), MText3.Text.Substring(3)).ToString();
                MainTitleText.Text = "List of all committees for specific month.";
                MainTitleText.Show();
                LoadingLabel.Show();
                MDataGrid.Show();
                LoadingLabel.Hide();
                ResultText1.Show();
                ResultText1.Text = "Total Enteries : " + MDataGrid.Rows.Count.ToString() + "      Total Amount : " + dres.ToString() + "           Date : " + MText3.Text.ToString();

            }

            if (MainTab1.Text == "Date Wise" & MainTab1.selected == true)
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone is not in valid formate.");
                    return;
                }
                if (MText2.TextLength == 0)
                {
                    MessageBox.Show("Name must be required.");
                    return;
                }

                if (MText3.TextLength == 0)
                {
                    MessageBox.Show("Date must be required.");
                    return;
                }
                if (MText3.Text.Substring(2, 1) != "/" || MText3.Text.Substring(5, 1) != "/")
                {
                    MessageBox.Show("Date should be in this form 01/12/2000");
                    return;
                }

                SQLHelpers sQLHelpers = new SQLHelpers();
                CommitteeInfo committeeInfo = sQLHelpers.GetMCommitteeDateWise
                    (MText1.Text.ToString(), MText2.Text.ToString(), DateTime.Parse(MText3.Text.ToString()));

                MText4.Show();
                MLabel4.Show();
                MLabel4.Text = "Amount";
                MResetButton.Hide();
                MAddButton.Show();
                MHelper3.Show();
                MHelper3.Text = "eg. dd/mm/yyyy";
                MAddButton.Text = "Back";
                if (committeeInfo != null)
                {
                    MText4.Text = committeeInfo.CAmount.ToString();
                }
                else
                    MText4.Text = "0";

                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;



            }
            if (MainTab1.Text == "Update" & MainTab1.selected == true & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {

                CommitteeInfo committeeInfo = new CommitteeInfo();
                committeeInfo = committeeInfo.GetCommitteeInfo(MText1.Text,
                MText2.Text, DateTime.Parse(MText3.Text));

                if (committeeInfo != null)
                {
                    MLabel4.Show();
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText4.Enabled = false;
                    MText1.Text = committeeInfo.MPhone;
                    MText2.Text = committeeInfo.MName;
                    MText4.Text = committeeInfo.CDate.ToShortDateString();
                    MAddButton.Show();
                    MResetButton.Hide();
                    MAddButton.Text = "Update";
                    MComboBox2.Show();
                    MComboBox2.Enabled = false;
                    if (committeeInfo.CAmount == 50)
                        MComboBox2.Text = "Daily";
                    if (committeeInfo.CAmount == 1500)
                        MComboBox2.Text = "Monthly";
                    MLabel3.Text = "Type";
                    MLabel4.Text = "Date";
                    MHelper3.Hide();
                    MHelper4.Text = "eg. dd/mm/yy";

                    CMPhone = committeeInfo.MPhone;
                    CMName = committeeInfo.MName;
                    MUpdate3.Show();
                    MSearchButton.Hide();
                    MText3.Hide();
                    MText4.Show();


                }
                else
                    MessageBox.Show("There is no record found");


            }
            if (MResetButton.Text == "Reset")
            {
                SResetButton_Click(SResetButton, EventArgs.Empty);
                MText1.Text = "";
                MText2.Text = "";
                MText3.Text = "";
                MComboBox2.Text = "Select";
                MText4.Text = "";
            }
            if (MainTab2.Text == "Delete" & MainTab2.selected == true & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {

                CommitteeInfo committeeInfo = new CommitteeInfo();
                committeeInfo = committeeInfo.GetCommitteeInfo(MText1.Text,
                MText2.Text, DateTime.Parse(MText3.Text));

                if (committeeInfo != null)
                {
                    MLabel4.Show();
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText4.Enabled = false;
                    MText1.Text = committeeInfo.MPhone;
                    MText2.Text = committeeInfo.MName;
                    MText4.Text = committeeInfo.CDate.ToShortDateString();
                    MAddButton.Show();
                    MResetButton.Hide();
                    MAddButton.Text = "Delete";
                    MComboBox2.Show();
                    MComboBox2.Enabled = false;
                    if (committeeInfo.CAmount == 50)
                        MComboBox2.Text = "Daily";
                    if (committeeInfo.CAmount == 1500)
                        MComboBox2.Text = "Monthly";
                    MLabel3.Text = "Type";
                    MLabel4.Text = "Date";
                    MHelper3.Hide();
                    MHelper4.Text = "eg. dd/mm/yy";

                    CMPhone = committeeInfo.MPhone;
                    CMName = committeeInfo.MName;
                    MSearchButton.Hide();
                    MText3.Hide();
                    MText4.Show();

                }
                else
                    MessageBox.Show("There is no record found");


            }
        }
        private void MChangeCNICLabel_Click(object sender, EventArgs e)
        {
            MText1.Enabled = true;
        }
        private void MChangeNameLabel_Click(object sender, EventArgs e)
        {
            MText2.Enabled = true;
        }
        private void MChangeAddressLabel_Click(object sender, EventArgs e)
        {
            MText3.Enabled = true;
            MComboBox2.Enabled = true;
        }
        private void MChangePhoneLable_Click(object sender, EventArgs e)
        {
            MText4.Enabled = true;
        }
        private void LoadMGrid()
        {
            SQLHelpers sQLHelpers = new SQLHelpers();
            SetMDataSource(sQLHelpers.GetAllMembers());
        }
        private void SetMDataSource(BindingSource bindingSource)
        {
            // Invoke method if required:
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(SetSDataSource), bindingSource);
            }
            else
            {
                MDataGrid.DataSource = bindingSource;
                DataGridProgess.Visible = false;
            }
        }
        private void LoadSGrid()
        {
            StockInfo stockInfo = new StockInfo();
            SetSDataSource(stockInfo.GetAllRecords());

        }
        private void SetSDataSource(BindingSource bindingSource)
        {
            try
            {
                // Invoke method if required:
                if (this.InvokeRequired)
                {
                    this.Invoke(new SetDataSourceDelegate(SetSDataSource), bindingSource);
                }
                else
                {
                    MDataGrid.DataSource = bindingSource;
                    DataGridProgess.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dataGridProgress()
        {
        }
        private void MSearchButton_Click(object sender, EventArgs e)
        {

            if (MainTab2.Text == "All Member Leases" & MainTab2.selected == true)
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                MSearchButton.Hide();
                DataGridProgess.Visible = true;
                LoadingLabel.Show();
                MDataGrid.DataSource = memberLeasesInfo.GetAllMemberLeasesInfo();
                MDataGrid.Show();
                MainTitleText.Text = "List of all member leases.";
                MLabel1.Hide();
                ResultText1.Show();
                MainTitleText.Show();
                ResultText1.Text = string.Format("Total member leases : {0}", MDataGrid.Rows.Count);
                LoadingLabel.Hide();
            }
            if (MainTab4.Text == "All Outsider Leases" & MainTab4.selected == true)
            {
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo();
                MSearchButton.Hide();
                DataGridProgess.Visible = true;
                LoadingLabel.Show();
                MDataGrid.DataSource = outsiderLeasesInfo.GetAllOutsiderLeasesInfo();
                MDataGrid.Show();
                MainTitleText.Text = "List of all outsider leases.";
                MLabel1.Hide();
                ResultText1.Show();
                MainTitleText.Show();
                ResultText1.Text = string.Format("Total member leases : {0}", MDataGrid.Rows.Count);
                LoadingLabel.Hide();
            }
            if (MainTab2.Text == "Check All Customers" & Main_Running_Control.Text == "   - ( Show Customer's Information )")
            {
                NetSellingInfo netSellingInfo = new NetSellingInfo();
                MSearchButton.Hide();
                DataGridProgess.Visible = true;
                LoadingLabel.Show();
                MDataGrid.DataSource = netSellingInfo.GetAllNetSellingInfo();
                MDataGrid.Show();
                MainTitleText.Text = "List of all customers.";
                MLabel1.Hide();
                ResultText1.Show();
                MainTitleText.Show();
                ResultText1.Text = string.Format("Total customers : {0}", MDataGrid.Rows.Count);
                LoadingLabel.Hide();

            }
            if (MainTab2.Text == "Check All Members" & MainTab2.selected == true)
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                MSearchButton.Hide();
                DataGridProgess.Show();
                DataGridProgess.Visible = true;
                MDataGrid.DataSource = sQLHelpers.GetAllMembers();
                MainTitleText.Text = "List of all members.";
                MDataGrid.Show();
                MLabel1.Hide();
                ResultText1.Show();
                MainTitleText.Show();
                ResultText1.Text = string.Format("Total members : {0}", MDataGrid.Rows.Count);

            }
            if (MainTab1.Text == BMonthly.Text & Main_Running_Control.Text == " -   ( Track Selling Records )")
            {

            }
            if (MainTab1.Text == BMonthly.Text & Main_Running_Control.Text == " -   ( Track Monthly Amount )")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                MSearchButton.Hide();
                MLabel1.Hide();
                MText1.Hide();
                MHelper1.Hide();
                if (MText1.Text.Substring(0, 3).Substring(2) != "/")
                {
                    MessageBox.Show("Month and Year should be in this formate \"01/2000\"");
                }
                MDataGrid.DataSource = sQLHelpers.GetAllMonthlyCommittee(MText1.Text.Substring(0, 2), MText1.Text.Substring(3));
                var dres = sQLHelpers.GetMonthlyCommitteeSum(MText1.Text.Substring(0, 2), MText1.Text.Substring(3)).ToString();
                MainTitleText.Text = "List of all committees for specific date.";
                MainTitleText.Show();
                LoadingLabel.Show();
                MDataGrid.Show();
                LoadingLabel.Hide();
                ResultText1.Show();
                ResultText1.Text = "Total Enteries : " + MDataGrid.Rows.Count.ToString() + "      Total Amount : " + dres.ToString() + "           Date : " + MText1.Text.ToString();

            }
            if (MainTab1.Text == BDaily.Text & Main_Running_Control.Text == " -   ( Track Daily Amount )")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                MSearchButton.Hide();
                MLabel1.Hide();
                MText1.Hide();
                MHelper1.Hide();
                MDataGrid.DataSource = sQLHelpers.GetAllDailyCommittee(DateTime.Parse(MText1.Text.ToString()));
                var dres = sQLHelpers.GetDailyCommitteeSum(DateTime.Parse(MText1.Text.ToString())).ToString();
                MainTitleText.Text = "List of all committees for specific date.";
                MainTitleText.Show();
                LoadingLabel.Show();
                MDataGrid.Show();
                LoadingLabel.Hide();
                ResultText1.Show();
                ResultText1.Text = "Total Enteries : " + MDataGrid.Rows.Count.ToString() + "      Total Amount : " + dres.ToString() + "           Date : " + MText1.Text.ToString();


            }
            if (MainTab1.Text == "Delete Lease")
            {   //if validate cnic

                ShowMemberItems();
                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MSearchButton.Hide();
                MAddButton.Text = "Delete";
                MResetButton.Hide();
                MLabel2.Text = "Engine No.";
                MLabel3.Text = "Advance";
                MLabel4.Text = "Date";

            }
            if (MainTab1.Text == "Check Specific Record" & MainTab1.selected == true)
            {   //if validate cnic

                StockInfo stockInfo = new StockInfo();
                if (stockInfo.StockValidation(MText1.Text))
                {
                    ShowStockItems();
                    stockInfo = stockInfo.GetStockInfo(MText1.Text);
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;
                    MText8.Enabled = false;
                    MCheck1.Enabled = false;
                    MCheck2.Enabled = false;

                    MText1.Text = stockInfo.SEngineNo;
                    MText2.Text = stockInfo.SChassisNo;
                    MText3.Text = stockInfo.SCompany;
                    MText4.Text = stockInfo.SModel;
                    MText5.Text = stockInfo.SAmount.ToString();
                    MText6.Text = stockInfo.SRegNo;
                    MText7.Text = stockInfo.SFileNo;
                    MText8.Text = stockInfo.SDate.ToString();
                    if (stockInfo.CopyRecived == 1)
                        MCheck1.Checked = true;
                    else
                        MCheck1.Checked = false;
                    if (stockInfo.LetterRecived == 1)
                        MCheck2.Checked = true;
                    else
                        MCheck2.Checked = false;
                    MSearchButton.Hide();
                    SAddButton.Text = "Back";
                    SResetButton.Hide();
                }
                else
                {
                    MessageBox.Show("There is no record found against this engine number");

                }


            }
            if (MainTab2.Text == "Check All Records" & MainTab2.selected == true)
            {
                MSearchButton.Hide();
                DataGridProgess.Show();
                DataGridProgess.Visible = true;
                System.Threading.Thread thread =
                  new System.Threading.Thread(new System.Threading.ThreadStart(LoadSGrid));
                thread.Start();
                dataGridProgress();
                MainTitleText.Text = "List of all records.";
                MDataGrid.Show();
                MLabel1.Hide();
                ResultText1.Show();
                MainTitleText.Show();
            }
            if (MainTab1.Text == "Check Specific Customer" & MainTab1.selected == true)
            {   //if validate cnic

                ShowMemberItems();
                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MSearchButton.Hide();
                MAddButton.Text = "Back";
                MResetButton.Hide();

            }
            if (MainTab1.Text == "Check Specific Lease" & MainTab1.selected == true)
            {   //if validate cnic

                ShowMemberItems();
                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MSearchButton.Hide();
                MAddButton.Text = "Back";
                MResetButton.Hide();
                MLabel2.Text = "Engine No.";
                MLabel3.Text = "Advance";
                MLabel4.Text = "Date";

            }
            if (MainTab1.Text == BUpdate.Text)
            {
                StockInfo stockInfo = new StockInfo();
                if (!stockInfo.StockValidation(MText1.Text))
                {
                    MessageBox.Show("There is no record found against this engine number");
                    return;
                }
                else
                {
                    ShowStockItems();
                    stockInfo = stockInfo.GetStockInfo(MText1.Text);
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;
                    MText8.Enabled = false;
                    MCheck1.Enabled = false;
                    MCheck2.Enabled = false;

                    MText1.Text = stockInfo.SEngineNo;
                    MText2.Text = stockInfo.SChassisNo;
                    MText3.Text = stockInfo.SCompany;
                    MText4.Text = stockInfo.SModel;
                    MText5.Text = stockInfo.SAmount.ToString();
                    MText6.Text = stockInfo.SRegNo;
                    MText7.Text = stockInfo.SFileNo;
                    MText8.Text = stockInfo.SDate.ToString();
                    if (stockInfo.CopyRecived == 1)
                        MCheck1.Checked = true;
                    else
                        MCheck1.Checked = false;
                    if (stockInfo.LetterRecived == 1)
                        MCheck2.Checked = true;
                    else
                        MCheck2.Checked = false;
                    MSearchButton.Hide();
                    SAddButton.Text = "Update";
                    ShowUpdate2();
                    SResetButton.Hide();
                    CSEngine = stockInfo.SEngineNo;
                }
            }
            if (MainTab1.Text == BDelete.Text & Main_Running_Control.Text == " -   ( Delete Stock Record )")
            {
                StockInfo stockInfo = new StockInfo();
                if (!stockInfo.StockValidation(MText1.Text))
                {
                    MessageBox.Show("There is no record found against this engine number");

                }
                else
                {
                    ShowStockItems();
                    stockInfo = stockInfo.GetStockInfo(MText1.Text);
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;
                    MText8.Enabled = false;
                    MCheck1.Enabled = false;
                    MCheck2.Enabled = false;

                    MText1.Text = stockInfo.SEngineNo;
                    MText2.Text = stockInfo.SChassisNo;
                    MText3.Text = stockInfo.SCompany;
                    MText4.Text = stockInfo.SModel;
                    MText5.Text = stockInfo.SAmount.ToString();
                    MText6.Text = stockInfo.SRegNo;
                    MText7.Text = stockInfo.SFileNo;
                    MText8.Text = stockInfo.SDate.ToString();
                    if (stockInfo.CopyRecived == 1)
                        MCheck1.Checked = true;
                    else
                        MCheck1.Checked = false;
                    if (stockInfo.LetterRecived == 1)
                        MCheck2.Checked = true;
                    else
                        MCheck2.Checked = false;
                    MSearchButton.Hide();
                    SAddButton.Text = "Delete";
                    SResetButton.Hide();
                }
            }
            if (MainTab1.Text == BUpdateCustomer.Text)
            {
                BNewCustomer_Click(BNewRecord, EventArgs.Empty);
                SResetButton.Hide();
                MSearchButton.Hide();
                Main_Running_Control.Text = " -   ( Update Customer Information )";
                MainTab1.Text = "Update Customer";

                // Disable all textbox

                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MText5.Enabled = false;
                MText6.Enabled = false;
                MText7.Enabled = false;

                // Showing update label

                ShowUpdate3();
                NResetButton.Show();
                NResetButton.Text = "Back";
                NAddButton.Text = "Update";
            }
            if (MainTab1.Text == BDeleteCustomer.Text)
            {
                BNewCustomer_Click(BNewRecord, EventArgs.Empty);
                SResetButton.Hide();
                MSearchButton.Hide();
                Main_Running_Control.Text = " -   ( Delete Customer Information )";
                MainTab1.Text = "Delete Customer";

                // Disable all textbox

                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MText5.Enabled = false;
                MText6.Enabled = false;
                MText7.Enabled = false;

                // Showing update label

                HideUpdate3();
                NResetButton.Show();
                NResetButton.Text = "Back";
                NAddButton.Text = "Delete";
            }
            if (MainTab1.Text == "Check Specific Member" & MainTab1.selected == true)
            {
                BNewCustomer_Click(BNewRecord, EventArgs.Empty);
                SResetButton.Hide();
                MSearchButton.Hide();
                Main_Running_Control.Text = " -   ( Show Customer's Information )";
                MainTab1.Text = "Show Information";

                // Disable all textbox

                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MText4.Enabled = false;
                MText5.Enabled = false;
                MText6.Enabled = false;
                MText7.Enabled = false;

                // Showing update label

                HideUpdate3();
                NResetButton.Hide();
                NAddButton.Text = "Back";
            }
        }
        private void BNewRecord_Click(object sender, EventArgs e)
        {
            ResetAll();
            SAddButton.Text = "Add";
            Stock_Panel.Hide();

            Main_Running_Control.Show();
            Main_Running_Control.Text = " -   ( Enter new record's information )";
            // Tab Setting
            MainTab1.Show();
            MainTab1.Text = BNewRecord.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Enable textbox 

            MText1.Enabled = true;
            MText2.Enabled = true;
            MText3.Enabled = true;
            MText4.Enabled = true;
            MText5.Enabled = true;
            MText6.Enabled = true;
            MText7.Enabled = true;
            MText8.Enabled = true;
            MCheck1.Enabled = true;
            MCheck2.Enabled = true;

            ShowStockItems();
        }
        private void MUpdate5_Click(object sender, EventArgs e)
        {
            MText5.Enabled = true;
        }
        private void MUpdate6_Click(object sender, EventArgs e)
        {
            MText6.Enabled = true;
        }
        private void MUpdate7_Click(object sender, EventArgs e)
        {
            MText7.Enabled = true;
        }
        private void MUpdate8_Click(object sender, EventArgs e)
        {
            MText8.Enabled = true;
        }
        private void BUpdate_Click(object sender, EventArgs e)
        {
            ResetAll();
            // Items to show 
            ShowCheckItems();
            MLabel1.Text = "Engine No.";
            MText1.Enabled = true;
            Stock_Panel.Hide();

            // Tab setting
            Main_Running_Control.Text = " -   ( Update Stock Record )";
            MainTab1.Show();
            MainTab1.Text = BUpdate.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

        }
        private void BDelete_Click(object sender, EventArgs e)
        {
            ResetAll();
            // Items to show 
            ShowCheckItems();
            MLabel1.Text = "Engine No.";
            MText1.Enabled = true;
            Stock_Panel.Hide();

            // Tab setting
            MainTab1.Show();
            Main_Running_Control.Text = " -   ( Delete Stock Record )";
            MainTab1.Text = BDelete.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
        }
        private void BCheck_Click(object sender, EventArgs e)
        {
            ResetAll();
            MComboBox1.Hide();
            // Items to show 
            Main_Running_Control.Text = " -   ( Check Stock Record )";
            ShowCheckItems();
            MLabel1.Text = "Engine No.";
            MText1.Enabled = true;
            Stock_Panel.Hide();

            // Tab Setting for Modify Committee Control
            MainTab1.Show();
            MainTab2.Show();
            MainTab1.Text = "Check Specific Record";
            MainTab2.Text = "Check All Records";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

        }
        private void BNewCustomer_Click(object sender, EventArgs e)
        {
            ResetAll();
            NetSelling_Panel.Hide();
            Stock_Panel.Hide();
            Main_Running_Control.Text = " -   ( Enter customer's information )";

            // Tab Setting

            MainTab1.Show();
            MainTab1.Text = BNewCustomer.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Enable textbox 

            MText1.Enabled = true;
            MText2.Enabled = true;
            MText3.Enabled = true;
            MText4.Enabled = true;
            MText5.Enabled = true;
            MText6.Enabled = true;
            MText7.Enabled = true;

            ShowNetSellingItems();

            MText1.MaxLength = 15;
            MText2.MaxLength = 25;
            MText3.MaxLength = 100;
            MText4.MaxLength = 11;
            MText5.MaxLength = 50;
            MText6.MaxLength = 5;
            MText7.MaxLength = 10;

            MHelper1.Show();
            MHelper1.Text = "eg. 11111-1111111-1";
            MHelper2.Show();
            MHelper2.Text = "eg. Hussain Ali";
            MHelper4.Show();
            MHelper4.Text = "eg. 03111111111";
            MHelper7.Show();
            MHelper7.Text = "eg. dd/mm/yyyy";




        }
        private void BUpdateCustomer_Click(object sender, EventArgs e)
        {

            ResetAll();

            // Tab Setting

            MainTab1.Show();
            Main_Running_Control.Text = " -   ( Update Customer's Information )";
            MainTab1.Text = BUpdateCustomer.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Hiding items

            ShowCheckItems();
            NetSelling_Panel.Hide();
            MSearchButton.Hide();
            MSearchButton2.Show();
            MSearchButton2.Text = "Search";
            MLabel2.Show();
            MLabel1.Text = "Phone";
            MHelper1.Show();
            MHelper1.Text = "eg. 03331122334";
            MLabel2.Text = "Engine No";
            MText2.Show();
            MText1.MaxLength = 11;
            MText2.MaxLength = 50;
        }
        private void MUpdate9_Click(object sender, EventArgs e)
        {
            MText9.Enabled = true;
            MCheck1.Enabled = true;
        }
        private void MUpdate10_Click(object sender, EventArgs e)
        {
            MText10.Enabled = true;
            MCheck2.Enabled = true;
        }
        private void MText2_TextChanged(object sender, EventArgs e)
        {

        }
        private void BDeleteCustomer_Click(object sender, EventArgs e)
        {
            ResetAll();

            // Tab Setting

            MainTab1.Show();
            Main_Running_Control.Text = " -   ( Delete Customer's Information )";
            MainTab1.Text = BDeleteCustomer.Text;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Hiding items

            ShowCheckItems();
            NetSelling_Panel.Hide();
            MSearchButton.Hide();
            MSearchButton2.Show();
            MSearchButton2.Text = "Search";
            MLabel2.Show();
            MLabel1.Text = "Phone";
            MHelper1.Show();
            MHelper1.Text = "eg. 03331122334";
            MLabel2.Text = "Engine No";
            MText2.Show();
            MText1.MaxLength = 11;
            MText2.MaxLength = 50;

        }
        private void BShowInformation_Click(object sender, EventArgs e)
        {
            ResetAll();

            // Tab Setting

            MainTab2.Show();
            MainTab1.Show();
            Main_Running_Control.Text = "   - ( Show Customer's Information )";
            MainTab1.Text = "Check Specific Customer";
            MainTab2.Text = "Check All Customers";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Showing Items 

            ShowCheckItems();
            NetSelling_Panel.Hide();

            MSearchButton.Hide();
            MSearchButton2.Show();
            MSearchButton2.Text = "Search";
            MLabel2.Show();
            MLabel1.Text = "Phone";
            MHelper1.Show();
            MHelper1.Text = "eg. 03331122334";
            MLabel2.Text = "Engine No";
            MText2.Show();
            MText1.MaxLength = 11;
            MText2.MaxLength = 50;
        }
        private void BAddExpenses_Click(object sender, EventArgs e)
        {
            ResetAll();
            MRichText1.BringToFront();
            MainTab1.Show();
            MainTab2.Show();
            MainTab1.Text = "Adding";
            MainTab2.Text = "Show";
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MainTab2.Show();
            MainTab2.selected = false;
            MainTab2.Enabled = true;
            Main_Running_Control.Text = " -   ( Expenses )";
            ManageBudget_Panel.Hide();
            ShowExpensesItems();

        }
        private void MComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MComboBox1.SelectedIndex == 0)
            {
                MainTab2_Click(MainTab2, EventArgs.Empty);
            }
            if (MComboBox1.SelectedIndex == 1)
            {
                MText2.Show();
                MLabel2.Show();
                MLabel2.Text = "Date";
                MSearchButton2.Show();

            }
            if (MComboBox1.SelectedIndex == 2)
            {
                MText2.Show();
                MLabel2.Show();
                MLabel2.Text = "Month";
                MSearchButton2.Show();
            }
            if (MComboBox1.SelectedIndex == 3)
            {
                MText2.Show();
                MLabel2.Show();
                MLabel2.Text = "Year";
                MSearchButton2.Show();
            }
        }
        private void MSearchButton2_Click(object sender, EventArgs e)
        {
            if (MainTab3.Text == "Total" & MainTab3.selected == true)
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone is not in valid formate.");
                    return;
                }
                if (MText2.TextLength == 0)
                {
                    MessageBox.Show("Name must be required.");
                    return;
                }

                SQLHelpers sQLHelpers = new SQLHelpers();
                var STotal = sQLHelpers.GetMCommitteeTotalSum(MText1.Text.ToString(), MText2.Text.ToString());
                int Total = 49500;
                int Remaining = Total - Int32.Parse(STotal);

                if (STotal == null)
                {
                    MessageBox.Show("There is no record found.");
                    return;
                }

                MHelper1.Hide();
                MHelper2.Hide();
                MSearchButton2.Hide();
                MText1.Hide();
                MText2.Hide();
                MLabel1.Text = "Total Amount                    :               " + Total;
                MLabel2.Text = "Amount Paid                     :               " + STotal;
                MLabel3.Show();
                MLabel3.Text = "Remaining Amount           :               " + Remaining;
                MResetButton.Text = "Back";
                MResetButton.Show();
            }
            if (MainTab1.Text == "Check Specific Customer"
                & MainTab1.selected == true)
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone number is not valid.");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                NetSellingInfo netSellingInfo = new NetSellingInfo();
                netSellingInfo = netSellingInfo.GetNetSellingInfo(MText1.Text.ToString(), MText2.Text.ToString());
                if (netSellingInfo != null)
                {
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;

                    MText1.Text = netSellingInfo.CCnic;
                    MText2.Text = netSellingInfo.CName;
                    MText3.Text = netSellingInfo.CAddress;
                    MText4.Text = netSellingInfo.CPhone;
                    MText5.Text = netSellingInfo.SEngineNo;
                    MText7.Text = netSellingInfo.CDate.ToShortDateString();
                    MText6.Text = netSellingInfo.CAmount.ToString();
                    ShowNetSellingItems();
                    NAddButton.Text = "Back";
                    NResetButton.Hide();
                    MSearchButton2.Hide();

                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }
            }
            if (MainTab1.Text == BUpdateCustomer.Text
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Update Customer's Information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone number is not valid.");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                NetSellingInfo netSellingInfo = new NetSellingInfo();
                netSellingInfo = netSellingInfo.GetNetSellingInfo(MText1.Text.ToString(), MText2.Text.ToString());
                if (netSellingInfo != null)
                {
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;

                    MText1.Text = netSellingInfo.CCnic;
                    MUpdate1.Show();
                    MText2.Text = netSellingInfo.CName;
                    MUpdate2.Show();
                    MText3.Text = netSellingInfo.CAddress;
                    MUpdate3.Show();
                    MText4.Text = netSellingInfo.CPhone;
                    MUpdate4.Text = "Cannot be changed";
                    MUpdate4.Enabled = false;
                    MUpdate4.ForeColor = Color.Red;
                    MUpdate4.Show();
                    MText5.Text = netSellingInfo.SEngineNo;
                    MUpdate5.Text = "Cannot be changed";
                    MUpdate5.Enabled = false;
                    MUpdate5.ForeColor = Color.Red;
                    MUpdate5.Show();
                    MText7.Text = netSellingInfo.CDate.ToShortDateString();
                    MUpdate7.Show();
                    MText6.Text = netSellingInfo.CAmount.ToString();
                    MUpdate6.Show();
                    ShowNetSellingItems();
                    NAddButton.Text = "Update";
                    NResetButton.Hide();
                    MSearchButton2.Hide();

                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }
            }
            if (MainTab1.Text == BDeleteCustomer.Text
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Delete Customer's Information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone number is not valid.");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                NetSellingInfo netSellingInfo = new NetSellingInfo();
                netSellingInfo = netSellingInfo.GetNetSellingInfo(MText1.Text.ToString(), MText2.Text.ToString());
                if (netSellingInfo != null)
                {
                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;
                    MText5.Enabled = false;
                    MText6.Enabled = false;
                    MText7.Enabled = false;

                    MText1.Text = netSellingInfo.CCnic;
                    MText2.Text = netSellingInfo.CName;
                    MText3.Text = netSellingInfo.CAddress;
                    MText4.Text = netSellingInfo.CPhone;
                    MText5.Text = netSellingInfo.SEngineNo;
                    MText7.Text = netSellingInfo.CDate.ToShortDateString();
                    MText6.Text = netSellingInfo.CAmount.ToString();
                    ShowNetSellingItems();
                    NAddButton.Text = "Delete";
                    NResetButton.Hide();
                    MSearchButton2.Hide();

                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }
            }
            if (MainTab1.Text == BUpdateMember.Text
                & Main_Running_Control.Text == " -   ( Update Member's Information )")
            {
                // If Cnic is valid
                Validation validation = new Validation();
                if (MText1.Text == "" || MText2.Text == "")
                {
                    MessageBox.Show("Both name and phone must be required.");
                    return;
                }
                if (validation.MemberValidation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    SQLHelpers sQLHelpers = new SQLHelpers();
                    MembersInfo membersInfo = sQLHelpers.GetMembersInfo(MText1.Text.ToString(), MText2.Text.ToString());
                    ShowMemberItems();

                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;

                    MText1.MaxLength = 15;
                    MText2.MaxLength = 25;
                    MText3.MaxLength = 100;
                    MText4.MaxLength = 11;

                    MHelper1.Text = "eg. 11111-1111111-1";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper4.Text = "eg.03001234567";

                    MHelper4.Show();

                    MText1.Text = membersInfo.MCnic;
                    MText2.Text = membersInfo.MName;
                    MText3.Text = membersInfo.MAddress;
                    MText4.Text = membersInfo.MPhone;

                    ShowUpdatelabels();
                    MUpdate2.Enabled = false;
                    MUpdate2.Text = "Cannot be changed";
                    MUpdate2.ForeColor = Color.Red;

                    MUpdate4.Enabled = false;
                    MUpdate4.Text = "Cannot be changed";
                    MUpdate4.ForeColor = Color.Red;

                    MSearchButton2.Hide();
                    MSearchButton.Hide();
                    MAddButton.Text = "Update";
                    MResetButton.Hide();

                    CMembersInfo.MPhone = membersInfo.MPhone;
                    CMembersInfo.MName = membersInfo.MName;
                }
                else
                {
                    MessageBox.Show("Given information is wrong.");
                    return;
                }
            }
            if (MainTab1.Text == BDeleteMember.Text
                & Main_Running_Control.Text == " -   ( Delete Member's Information )")
            {
                // If Cnic is valid
                Validation validation = new Validation();
                if (MText1.Text == "" || MText2.Text == "")
                {
                    MessageBox.Show("Both name and phone must be required.");
                    return;
                }
                if (validation.MemberValidation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    SQLHelpers sQLHelpers = new SQLHelpers();
                    MembersInfo membersInfo = sQLHelpers.GetMembersInfo(MText1.Text.ToString(), MText2.Text.ToString());
                    ShowMemberItems();

                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;

                    MHelper1.Text = "eg. 11111-1111111-1";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper4.Text = "eg.03001234567";

                    MHelper4.Show();

                    MText1.Text = membersInfo.MCnic;
                    MText2.Text = membersInfo.MName;
                    MText3.Text = membersInfo.MAddress;
                    MText4.Text = membersInfo.MPhone;

                    MSearchButton2.Hide();
                    MSearchButton.Hide();
                    MAddButton.Text = "Delete";
                    MResetButton.Hide();

                }
                else
                {
                    MessageBox.Show("Given information is wrong.");
                    return;
                }
            }
            if (MainTab1.Text == "Check Specific Member"
                & Main_Running_Control.Text == " -   ( Show Member's Information )")
            {
                // If Cnic is valid
                Validation validation = new Validation();
                if (MText1.Text == "" || MText2.Text == "")
                {
                    MessageBox.Show("Both name and phone must be required.");
                    return;
                }
                if (validation.MemberValidation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    SQLHelpers sQLHelpers = new SQLHelpers();
                    MembersInfo membersInfo = sQLHelpers.GetMembersInfo(MText1.Text.ToString(), MText2.Text.ToString());
                    ShowMemberItems();

                    MText1.Enabled = false;
                    MText2.Enabled = false;
                    MText3.Enabled = false;
                    MText4.Enabled = false;

                    MHelper1.Text = "eg. 11111-1111111-1";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper4.Text = "eg.03001234567";

                    MHelper4.Show();

                    MText1.Text = membersInfo.MCnic;
                    MText2.Text = membersInfo.MName;
                    MText3.Text = membersInfo.MAddress;
                    MText4.Text = membersInfo.MPhone;

                    MSearchButton2.Hide();
                    MSearchButton.Hide();
                    MAddButton.Text = "Back";
                    MResetButton.Hide();

                }
                else
                {
                    MessageBox.Show("Given information is wrong.");
                    return;
                }
            }
            if (MainTab2.Text == "For Outsider"
                & MainTab2.selected == true
                & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo();
                if (outsiderLeasesInfo.Validation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    outsiderLeasesInfo = outsiderLeasesInfo.GetOutsiderLeasesInfo
                        (MText1.Text.ToString(), MText2.Text.ToString());
                    BNewCustomer_Click(BNewCustomer, EventArgs.Empty);
                    MainTab1.Text = "For Member";
                    MLabel6.Text = "Advance";
                    MLabel7.Text = "Amount";
                    MLabel8.Text = "Duration";
                    MLabel9.Text = "Installment";
                    MLabel10.Text = "Date";
                    MLabel8.Show();
                    MLabel9.Show();
                    MLabel10.Show();
                    MText8.Show();
                    MText9.Show();
                    MText10.Show();
                    Main_Running_Control.Text = " -   ( Update lease information )";
                    MainTab2.Show();
                    NResetButton.Hide();
                    NAddButton.Hide();
                    SAddButton.Show();
                    SAddButton.Text = "Update";
                    MainTab2.selected = true;
                    MainTab1.selected = false;
                    ShowUpdate2();
                    MUpdate4.Text = "Cannot be changed.";
                    MUpdate4.ForeColor = Color.Red;
                    MUpdate4.Enabled = false;

                    MUpdate5.Text = "Cannot be changed.";
                    MUpdate5.ForeColor = Color.Red;
                    MUpdate5.Enabled = false;


                    MText1.Text = outsiderLeasesInfo.OLCnic;
                    MText2.Text = outsiderLeasesInfo.OLName;
                    MText3.Text = outsiderLeasesInfo.OLAddress;
                    MText4.Text = outsiderLeasesInfo.OLPhone;
                    MText5.Text = outsiderLeasesInfo.SEngineNo;
                    MText6.Text = outsiderLeasesInfo.OLAmount.ToString();
                    MText7.Text = outsiderLeasesInfo.OLDuration.ToString();
                    MText8.Text = outsiderLeasesInfo.OLAdvance.ToString();
                    MText9.Text = outsiderLeasesInfo.OLInstallment.ToString();
                    MText10.Text = outsiderLeasesInfo.OLDate.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }

            }
            if (MainTab2.Text == "For Outsider"
               & MainTab2.selected == true
               & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo();
                if (outsiderLeasesInfo.Validation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    outsiderLeasesInfo = outsiderLeasesInfo.GetOutsiderLeasesInfo
                        (MText1.Text.ToString(), MText2.Text.ToString());
                    BNewCustomer_Click(BNewCustomer, EventArgs.Empty);
                    MLabel6.Text = "Advance";
                    MLabel7.Text = "Amount";
                    MLabel8.Text = "Duration";
                    MLabel9.Text = "Installment";
                    MLabel10.Text = "Date";
                    MLabel8.Show();
                    MLabel9.Show();
                    MLabel10.Show();
                    MText8.Show();
                    MText9.Show();
                    MText10.Show();
                    Main_Running_Control.Text = " -   ( Delete lease information )";
                    MainTab2.Show();
                    NResetButton.Hide();
                    NAddButton.Hide();
                    SAddButton.Show();
                    SAddButton.Text = "Delete";
                    MainTab2.selected = true;
                    MainTab1.selected = false;
                    MText1.Text = outsiderLeasesInfo.OLCnic;
                    MText1.Enabled = false;
                    MText2.Text = outsiderLeasesInfo.OLName;
                    MText2.Enabled = false;
                    MText3.Text = outsiderLeasesInfo.OLAddress;
                    MText3.Enabled = false;
                    MText4.Text = outsiderLeasesInfo.OLPhone;
                    MText4.Enabled = false;
                    MText5.Text = outsiderLeasesInfo.SEngineNo;
                    MText5.Enabled = false;
                    MText6.Text = outsiderLeasesInfo.OLAmount.ToString();
                    MText6.Enabled = false;
                    MText7.Text = outsiderLeasesInfo.OLDuration.ToString();
                    MText8.Enabled = false;
                    MText8.Text = outsiderLeasesInfo.OLAdvance.ToString();
                    MText7.Enabled = false;
                    MText9.Text = outsiderLeasesInfo.OLInstallment.ToString();
                    MText9.Enabled = false;
                    MText10.Text = outsiderLeasesInfo.OLDate.ToShortDateString();
                    MText10.Enabled = false;
                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }

            }
            if (MainTab3.Text == "Check Outsider Lease"
              & MainTab3.selected == true
              & Main_Running_Control.Text == " -   ( Show lease information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Provided phone is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No. must be provided.");
                    return;
                }
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo();
                if (outsiderLeasesInfo.Validation(MText1.Text.ToString(), MText2.Text.ToString()))
                {
                    outsiderLeasesInfo = outsiderLeasesInfo.GetOutsiderLeasesInfo
                        (MText1.Text.ToString(), MText2.Text.ToString());
                    BNewCustomer_Click(BNewCustomer, EventArgs.Empty);
                    MLabel6.Text = "Advance";
                    MLabel7.Text = "Amount";
                    MLabel8.Text = "Duration";
                    MLabel9.Text = "Installment";
                    MLabel10.Text = "Date";
                    MLabel8.Show();
                    MLabel9.Show();
                    MLabel10.Show();
                    MText8.Show();
                    MText9.Show();
                    MText10.Show();
                    Main_Running_Control.Text = " -   ( Show lease information )";
                    MainTab2.Show();
                    NResetButton.Hide();
                    NAddButton.Hide();
                    SAddButton.Show();
                    SAddButton.Text = "Back";
                    MainTab3.selected = true;
                    MText1.Text = outsiderLeasesInfo.OLCnic;
                    MText1.Enabled = false;
                    MText2.Text = outsiderLeasesInfo.OLName;
                    MText2.Enabled = false;
                    MText3.Text = outsiderLeasesInfo.OLAddress;
                    MText3.Enabled = false;
                    MText4.Text = outsiderLeasesInfo.OLPhone;
                    MText4.Enabled = false;
                    MText5.Text = outsiderLeasesInfo.SEngineNo;
                    MText5.Enabled = false;
                    MText6.Text = outsiderLeasesInfo.OLAmount.ToString();
                    MText6.Enabled = false;
                    MText7.Text = outsiderLeasesInfo.OLDuration.ToString();
                    MText8.Enabled = false;
                    MText8.Text = outsiderLeasesInfo.OLAdvance.ToString();
                    MText7.Enabled = false;
                    MText9.Text = outsiderLeasesInfo.OLInstallment.ToString();
                    MText9.Enabled = false;
                    MText10.Text = outsiderLeasesInfo.OLDate.ToShortDateString();
                    MText10.Enabled = false;
                    MLabel1.Show();
                    MainTab1.Show();
                    MainTab2.Show();
                    MainTab3.Show();
                    MainTab4.Show();
                    Main_Running_Control.Text = " -   ( Show lease information )";
                    MainTab1.Text = "Check Member Lease";
                    MainTab2.Text = "All Member Leases";
                    MainTab3.Text = "Check Outsider Lease";
                    MainTab3.BorderStyle = BorderStyle.Fixed3D;
                    MainTab3.Enabled = true;
                    MainTab4.BorderStyle = BorderStyle.Fixed3D;
                    MainTab4.Enabled = true;
                    MainTab4.Text = "All Outsider Leases";

                }
                else
                {
                    MessageBox.Show("There is no information against this Phone and Engine No.");
                    return;
                }

            }
            if (MainTab1.Text == "For Member"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone lenght is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No must be required");
                    return;
                }
                memberLeasesInfo = memberLeasesInfo.GetMemberleasesInfo(MText2.Text.ToString(), MText1.Text.ToString());
                if (memberLeasesInfo != null)
                {

                    ShowMemberItems();
                    MAddButton.Hide();
                    MText1.Enabled = false;
                    MText1.Text = memberLeasesInfo.MPhone.ToString();
                    MText2.Enabled = false;
                    MText2.Text = memberLeasesInfo.MName.ToString();
                    MText3.Enabled = false;
                    MText3.Text = memberLeasesInfo.SEngineNo.ToString();
                    MText4.Enabled = false;
                    MText4.Text = memberLeasesInfo.MLAdvance.ToString();
                    MText5.Enabled = false;
                    MText5.Text = memberLeasesInfo.MLDate.ToShortDateString();
                    ShowUpdatelabels();
                    MUpdate1.Text = "Cannot be changed";
                    MUpdate1.Enabled = false;
                    MUpdate1.ForeColor = Color.Red;
                    MUpdate3.Text = "Cannot be changed";
                    MUpdate3.Enabled = false;
                    MUpdate3.ForeColor = Color.Red;
                    MSearchButton.Hide();
                    MSearchButton2.Hide();
                    MAddButton.Text = "Update";
                    MUpdate2.Text = "Cannot be changed";
                    MUpdate2.Enabled = false;
                    MUpdate2.ForeColor = Color.Red;
                    MResetButton.Hide();
                    MLabel1.Text = "Phone";
                    MHelper1.Show();
                    MHelper1.Text = "eg. 03333333333";
                    MLabel2.Text = "Name.";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper2.Show();
                    MLabel3.Text = "Engine No.";
                    MLabel4.Text = "Advance";
                    MLabel5.Text = "Date";
                    MHelper5.Show();
                    MHelper5.Text = "eg. dd/mm/yyyy";
                    LAddButton.Show();
                    LAddButton.Text = "Update";
                    MText5.Show();
                    MUpdate5.Show();
                    MLabel5.Show();


                }
            }
            if (MainTab1.Text == "For Member"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone lenght is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No must be required");
                    return;
                }
                memberLeasesInfo = memberLeasesInfo.GetMemberleasesInfo(MText2.Text.ToString(), MText1.Text.ToString());
                if (memberLeasesInfo != null)
                {

                    ShowMemberItems();
                    MAddButton.Hide();
                    MText1.Enabled = false;
                    MText1.Text = memberLeasesInfo.MPhone.ToString();
                    MText2.Enabled = false;
                    MText2.Text = memberLeasesInfo.MName.ToString();
                    MText3.Enabled = false;
                    MText3.Text = memberLeasesInfo.SEngineNo.ToString();
                    MText4.Enabled = false;
                    MText4.Text = memberLeasesInfo.MLAdvance.ToString();
                    MText5.Enabled = false;
                    MText5.Text = memberLeasesInfo.MLDate.ToShortDateString();
                    MSearchButton.Hide();
                    MSearchButton2.Hide();
                    MResetButton.Hide();
                    MLabel1.Text = "Phone";
                    MHelper1.Show();
                    MHelper1.Text = "eg. 03333333333";
                    MLabel2.Text = "Name.";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper2.Show();
                    MLabel3.Text = "Engine No.";
                    MLabel4.Text = "Advance";
                    MLabel5.Text = "Date";
                    MHelper5.Show();
                    MHelper5.Text = "eg. dd/mm/yyyy";
                    LAddButton.Show();
                    LAddButton.Text = "Delete";
                    MText5.Show();
                    MLabel5.Show();


                }
                else
                {
                    MessageBox.Show("There is no record found again this Phone and Engine No.");
                    return;
                }
            }
            if (MainTab1.Text == "Check Member Lease"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Show lease information )")
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone lenght is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Engine No must be required");
                    return;
                }
                memberLeasesInfo = memberLeasesInfo.GetMemberleasesInfo(MText2.Text.ToString(), MText1.Text.ToString());
                if (memberLeasesInfo != null)
                {

                    ShowMemberItems();
                    MAddButton.Hide();
                    MText1.Enabled = false;
                    MText1.Text = memberLeasesInfo.MPhone.ToString();
                    MText2.Enabled = false;
                    MText2.Text = memberLeasesInfo.MName.ToString();
                    MText3.Enabled = false;
                    MText3.Text = memberLeasesInfo.SEngineNo.ToString();
                    MText4.Enabled = false;
                    MText4.Text = memberLeasesInfo.MLAdvance.ToString();
                    MText5.Enabled = false;
                    MText5.Text = memberLeasesInfo.MLDate.ToShortDateString();
                    MSearchButton.Hide();
                    MSearchButton2.Hide();
                    MResetButton.Hide();
                    MLabel1.Text = "Phone";
                    MHelper1.Show();
                    MHelper1.Text = "eg. 03333333333";
                    MLabel2.Text = "Name.";
                    MHelper2.Text = "eg. Hussain Ali";
                    MHelper2.Show();
                    MLabel3.Text = "Engine No.";
                    MLabel4.Text = "Advance";
                    MLabel5.Text = "Date";
                    MHelper5.Show();
                    MHelper5.Text = "eg. dd/mm/yyyy";
                    LAddButton.Show();
                    LAddButton.Text = "Back";
                    MText5.Show();
                    MLabel5.Show();


                }
                else
                {
                    MessageBox.Show("There is no record found again this Phone and Engine No.");
                    return;
                }
            }
            if (MainTab1.Text == "Update"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Modify Installment Entry )")
            {
                MComboBox2.Hide();
                MText3.Show();
                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MLabel3.Show();
                MLabel2.Text = "Amount";
                MLabel3.Text = "Date";
                MUpdate1.Show();
                MUpdate2.Show();
                MUpdate3.Show();
                MSearchButton2.Hide();
                MAddButton.Show();
                MAddButton.Text = "Update";
                MResetButton.Show();
                MResetButton.Text = "Back";
            }
            if (MainTab1.Text == "Update"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {
                MComboBox2.Show();
                MComboBox2.Enabled = false;
                MText1.Enabled = false;
                MText2.Enabled = false;
                MLabel3.Show();
                MLabel3.Text = "Type";
                MUpdate1.Show();
                MUpdate2.Show();
                MUpdate3.Show();
                MSearchButton2.Hide();
                MAddButton.Show();
                MAddButton.Text = "Update";
                MResetButton.Show();
                MResetButton.Text = "Back";
            }
            if (MainTab2.Text == "Delete"
                & MainTab2.selected == true
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Modify Committee Entry )")
            {
                MComboBox2.Show();
                MComboBox2.Enabled = false;
                MText1.Enabled = false;
                MText2.Enabled = false;
                MLabel3.Show();
                MLabel3.Text = "Type";
                MUpdate1.Hide();
                MUpdate2.Hide();
                MUpdate3.Hide();
                MSearchButton2.Hide();
                MAddButton.Show();
                MAddButton.Text = "Delete";
                MResetButton.Show();
                MResetButton.Text = "Back";


            }
            if (MainTab2.Text == "Delete"
                & MainTab2.selected == true
                & Main_Running_Control.Text == " -   ( Modify Installment Entry )")
            {
                MComboBox2.Hide();
                MText3.Show();
                MText1.Enabled = false;
                MText2.Enabled = false;
                MText3.Enabled = false;
                MLabel3.Show();
                MLabel2.Text = "Amount";
                MLabel3.Text = "Date";
                MUpdate1.Hide();
                MUpdate2.Hide();
                MUpdate3.Hide();
                MSearchButton2.Hide();
                MAddButton.Show();
                MAddButton.Text = "Delete";
                MResetButton.Show();
                MResetButton.Text = "Back";


            }
        }
        private void BNewLease_Click(object sender, EventArgs e)
        {
            ResetAll();
            MainTab2.Text = "For Outsider";
            MainTab2.Show();
            MainTab2.BorderStyle = BorderStyle.Fixed3D;
            MainTab1.selected = true;
            Leasing_Panel.Hide();
            Main_Running_Control.Text = " -   ( Enter new lease information )";
            MainTab1.Show();
            MainTab1.Text = "For Member";
            MainTab1.Show();
            MLabel1.Text = "Phone";
            MLabel2.Text = "Name.";
            MHelper1.Text = "eg. 03002020199";
            MHelper2.Text = "eg. Hussain";
            MLabel3.Text = "Engine No.";
            MLabel4.Text = "Advnace";
            MLabel5.Text = "Date";
            MHelper5.Text = "eg. dd/mm/yyyy";

            //Showing Label

            MLabel1.Show();
            MLabel2.Show();
            MLabel3.Show();
            MLabel4.Show();
            MLabel5.Show();

            //Showing Text

            MText1.Show();
            MText2.Show();
            MText3.Show();
            MText4.Show();
            MText5.Show();

            //Checks

            MText1.MaxLength = 11;
            MText2.MaxLength = 25;
            MText3.MaxLength = 50;
            MText5.MaxLength = 10;

            //Show Helper

            MHelper1.Show();
            MHelper2.Show();
            MHelper3.Show();
            MHelper4.Show();
            MHelper5.Show();
            LResetButton.Show();
            LAddButton.Show();



        }
        private void BUpdateLease_Click(object sender, EventArgs e)
        {
            ResetAll();
            BUpdateMember_Click(BUpdateMember, EventArgs.Empty);
            Leasing_Panel.Hide();
            MainTab1.Show();
            MLabel1.Show();
            MainTab2.Show();
            MainTab1.Text = "For Member";
            MainTab2.Text = "For Outsider";
            Main_Running_Control.Text = " -   ( Update lease information )";
            MLabel2.Text = "Engine No.";
            MLabel2.Show();
            MText2.Show();
            MSearchButton.Hide();
            MSearchButton2.Show();
            MLabel3.Text = "Advance";
            MLabel4.Text = "Date";

        }
        private void BDeleteLease_Click(object sender, EventArgs e)
        {
            ResetAll();
            BDeleteMember_Click(BDeleteMember, EventArgs.Empty);
            Leasing_Panel.Hide();
            MainTab1.Show();
            MLabel1.Show();
            MainTab1.selected = true;
            MainTab2.Text = "For Outsider";
            MainTab2.Show();
            MainTab2.BorderStyle = BorderStyle.Fixed3D;
            MainTab1.Text =
            Main_Running_Control.Text = " -   ( Delete lease information )";
            MLabel2.Text = "Engine No.";
            MLabel3.Text = "Advance";
            MLabel4.Text = "Date";
            MainTab1.Text = "For Member";
        }
        private void BShowLInfo_Click(object sender, EventArgs e)
        {
            ResetAll();
            BShowMInfo_Click(BShowMInfo, EventArgs.Empty);
            Leasing_Panel.Hide();
            MLabel1.Show();
            MainTab1.Show();
            MainTab2.Show();
            MainTab3.Show();
            MainTab4.Show();
            Main_Running_Control.Text = " -   ( Show lease information )";
            MainTab1.Text = "Check Member Lease";
            MainTab2.Text = "All Member Leases";
            MainTab3.Text = "Check Outsider Lease";
            MainTab3.BorderStyle = BorderStyle.Fixed3D;
            MainTab3.Enabled = true;
            MainTab4.BorderStyle = BorderStyle.Fixed3D;
            MainTab4.Enabled = true;
            MainTab4.Text = "All Outsider Leases";
            MLabel2.Text = "Engine No.";
            MLabel3.Text = "Advance";
            MLabel4.Text = "Date";
        }
        private void SResetButton_Click(object sender, EventArgs e)
        {

            MCheck1.Checked = false;
            MCheck2.Checked = false;
            MRichText1.Text = "";
            MComboBox1.Text = "Select";
            MComboBox2.Text = "Select";
            MText1.Text = "";
            MText2.Text = "";
            MText3.Text = "";
            MText4.Text = "";
            MText5.Text = "";
            MText6.Text = "";
            MText7.Text = "";
            MText8.Text = "";
        }
        private void NResetButton_Click(object sender, EventArgs e)
        {
            SResetButton_Click(SResetButton, EventArgs.Empty);
        }
        private void Title_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            //mouseDown = false;
        }
        private void Title_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseDown = true;
        }
        private void MRichText1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BModifyCommittee_ClientSizeChanged(object sender, EventArgs e)
        {

        }
        private void BIEnter_Click(object sender, EventArgs e)
        {
            Installment_Panel.Hide();
            BEnterCommittee_Click(BEnterCommittee, EventArgs.Empty);
            Main_Running_Control.Text = " -   ( Installment Entry )";
            MainTab1.BorderStyle = BorderStyle.Fixed3D;
            MLabel2.Text = "Engine No. *";
            MLabel3.Text = "Amount";
            MLabel4.Text = "Date *";
            MHelper4.Text = "eg. dd/mm/yy";
            MHelper2.Hide();
            MHelper3.Hide();
            MComboBox2.Hide();
            MText3.Show();
        }
        private void BIModify_Click(object sender, EventArgs e)
        {
            Installment_Panel.Hide();
            BModifyCommittee_Click(BEnterCommittee, EventArgs.Empty);
            Main_Running_Control.Text = " -   ( Modify Installment Entry )";
            MLabel2.Text = "Engine No. *";
            MHelper2.Hide();
        }

        private void MinimizeButton_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        private void MainTab3_Click(object sender, EventArgs e)
        {
            if (MainTab3.Text == "Check Outsider Lease")
            {

                BUpdateLease_Click(BUpdateLease, EventArgs.Empty);
                Main_Running_Control.Text = " -   ( Show lease information )";
                MainTab1.Text = "Check Member Lease";
                Main_Running_Control.Text = " -   ( Show lease information )";
                MainTab2.Text = "All Member Leases";
                MainTab3.Show();
                MainTab4.Show();

            }
            if (MainTab3.Text == "Anually Total")
            {
                MLabel1.Text = "Year";
                MHelper1.Text = "eg. 2014";
            }
            if (MainTab3.Text == "Total")
            {
                MLabel1.Text = "Phone";
                MHelper1.Text = "eg. 03112211221";
                MText1.Show();
                MText1.Text = "";
                MText2.Text = "";
                MText1.MaxLength = 11;
                MText2.MaxLength = 25;
                MText2.Show();
                MLabel2.Text = "Name";
                MHelper2.Text = "eg. Hussain Ali";
                MResetButton.Hide();
                MSearchButton2.Show();
                MSearchButton2.Text = "Search";
                MText3.Hide();
                MLabel3.Hide();
                MHelper3.Hide();
                MText3.Hide();
                MResetButton.Hide();
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BMonthly_Click(BMonthly, EventArgs.Empty);
            Main_Running_Control.Text = " -   ( Track Selling Records )";
        }
        private void BCommitteeTotal_Click(object sender, EventArgs e)
        {
            ResetAll();
            ManageBudget_Panel.Hide();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = "Daily Total";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab2.Show();
            MainTab2.Text = "Monthly Total";
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab3.Show();
            MainTab3.Text = "Anually Total";
            MainTab3.Enabled = true;
            MainTab3.selected = false;
            MainTab3.BorderStyle = BorderStyle.Fixed3D;

            Main_Running_Control.Text = " -   ( Committee Total Amount  )";

            MLabel1.Show();
            MLabel1.Text = "Date";
            MText1.Show();
            MHelper1.Text = "eg. dd/mm/yy";
            MHelper1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Search";
        }
        private void BNetSellingTotal_Click(object sender, EventArgs e)
        {
            ResetAll();
            ManageBudget_Panel.Hide();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = "Daily Total";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab2.Show();
            MainTab2.Text = "Monthly Total";
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab3.Show();
            MainTab3.Text = "Anually Total";
            MainTab3.Enabled = true;
            MainTab3.selected = false;
            MainTab3.BorderStyle = BorderStyle.Fixed3D;

            Main_Running_Control.Text = " -   ( Net Selling Total Amount  )";

            MLabel1.Show();
            MLabel1.Text = "Date";
            MText1.Show();
            MHelper1.Text = "eg. dd/mm/yy";
            MHelper1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Search";
        }
        private void BLeaseTotal_Click(object sender, EventArgs e)
        {
            ResetAll();
            ManageBudget_Panel.Hide();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = "Daily Total";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab2.Show();
            MainTab2.Text = "Monthly Total";
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab3.Show();
            MainTab3.Text = "Anually Total";
            MainTab3.Enabled = true;
            MainTab3.selected = false;
            MainTab3.BorderStyle = BorderStyle.Fixed3D;

            Main_Running_Control.Text = " -   ( Leasing Total Amount  )";

            MLabel1.Show();
            MLabel1.Text = "Date";
            MText1.Show();
            MHelper1.Text = "eg. dd/mm/yy";
            MHelper1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Search";
        }
        private void BTotalIncome_Click(object sender, EventArgs e)
        {
            ResetAll();
            ManageBudget_Panel.Hide();

            // Tab Setting for Track Daily Control
            MainTab1.Show();
            MainTab1.Text = "Daily Total";
            MainTab1.Enabled = true;
            MainTab1.selected = true;
            MainTab1.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab2.Show();
            MainTab2.Text = "Monthly Total";
            MainTab2.Enabled = true;
            MainTab2.selected = false;
            MainTab2.BorderStyle = BorderStyle.Fixed3D;

            // Tab Setting for Track Daily Control
            MainTab3.Show();
            MainTab3.Text = "Anually Total";
            MainTab3.Enabled = true;
            MainTab3.selected = false;
            MainTab3.BorderStyle = BorderStyle.Fixed3D;

            Main_Running_Control.Text = " -   ( Total Income  )";

            MLabel1.Show();
            MLabel1.Text = "Date";
            MText1.Show();
            MHelper1.Text = "eg. dd/mm/yy";
            MHelper1.Show();
            MSearchButton.Show();
            MSearchButton.Text = "Search";
        }
        private void LResetButton_Click(object sender, EventArgs e)
        {
            MText1.Text = "";
            MText2.Text = "";
            MText3.Text = "";
            MText4.Text = "";
            MText5.Text = "";
        }
        private void LAddButton_Click(object sender, EventArgs e)
        {
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Enter new lease information )")
            {

                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone number is not valid");
                    return;
                }
                if (MText5.TextLength != 10)
                {
                    MessageBox.Show("Date is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Name must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Phone number must be requred");
                    return;
                }
                if (MText3.Text == "")
                {
                    MessageBox.Show("Engine No. must be required");
                    return;
                }
                if (MText5.Text == "")
                {
                    MessageBox.Show("Date must be required");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Advnace must be requred");
                    return;
                }
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();

                if (memberLeasesInfo.Validation(MText3.Text.ToString(), MText1.Text.ToString()) == false)
                {


                    memberLeasesInfo.MPhone = MText1.Text.ToString();
                    memberLeasesInfo.MName = MText2.Text.ToString();
                    memberLeasesInfo.SEngineNo = MText3.Text.ToString();
                    memberLeasesInfo.MLAdvance = Int32.Parse(MText4.Text.ToString());
                    memberLeasesInfo.MLDate = DateTime.Parse(MText5.Text.ToString());

                    StockInfo stockInfo = new StockInfo();

                    if (stockInfo.StockValidation(MText3.Text.ToString()) == false)
                    {
                        MessageBox.Show("There is no stock with this Engine Number.");
                        return;
                    }
                    SQLHelpers sQLHelpers = new SQLHelpers();

                    if (sQLHelpers.GetMembersInfo(MText1.Text.ToString(), MText2.Text.ToString()) == null)
                    {
                        MessageBox.Show("There is no member with this Phone and Name.");
                        return;
                    }

                    memberLeasesInfo.InsertMemberLeaseInfo(memberLeasesInfo);
                    MessageBox.Show("Record successfully added.");
                }
                else
                {
                    MessageBox.Show("Record already exists");
                    return;
                }
            }
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                if (MText1.TextLength != 11)
                {
                    MessageBox.Show("Phone number is not valid");
                    return;
                }
                if (MText5.TextLength != 10)
                {
                    MessageBox.Show("Date is not valid");
                    return;
                }
                if (MText2.Text == "")
                {
                    MessageBox.Show("Name must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Phone number must be requred");
                    return;
                }
                if (MText3.Text == "")
                {
                    MessageBox.Show("Engine No. must be required");
                    return;
                }
                if (MText5.Text == "")
                {
                    MessageBox.Show("Date must be required");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Advnace must be requred");
                    return;
                }

                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                memberLeasesInfo.MPhone = MText1.Text.ToString();
                memberLeasesInfo.MName = MText2.Text.ToString();
                memberLeasesInfo.SEngineNo = MText3.Text.ToString();
                memberLeasesInfo.MLAdvance = Int32.Parse(MText4.Text.ToString());
                memberLeasesInfo.MLDate = DateTime.Parse(MText5.Text.ToString());
                memberLeasesInfo.UpdateMemberLeasesInfo(memberLeasesInfo, MText3.Text.ToString(), MText1.Text.ToString());
                MessageBox.Show("Information successfully updated");
            }
            if (MainTab1.Text == "For Member" & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo();
                memberLeasesInfo.DeleteMemberLeasesInfo(MText3.Text.ToString(), MText1.Text.ToString());
                MessageBox.Show("Record successfully deleted.");
            }


        }
        private void NAddButton_Click(object sender, EventArgs e)
        {
            if (NAddButton.Text == "Update"
                & Main_Running_Control.Text == " -   ( Update Customer's Information )")
            {


                if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Provided cnic number is too short.");
                    return;
                }

                if (MText6.Text == "")
                {
                    MessageBox.Show("Amount must be required.");
                    return;
                }
                if (MText7.TextLength != 10)
                {
                    MessageBox.Show("Provided date is too short.");
                    return;
                }

                if (MText4.TextLength != 11)
                {
                    MessageBox.Show("Provided phone number is too short.");
                    return;
                }


                NetSellingInfo netSellingInfo = new NetSellingInfo
                {
                    CCnic = MText1.Text.ToString(),
                    CName = MText2.Text.ToString(),
                    CAddress = MText3.Text.ToString(),
                    CPhone = MText4.Text.ToString(),
                    SEngineNo = MText5.Text.ToString(),
                    CAmount = Int32.Parse(MText6.Text.ToString()),
                    CDate = DateTime.Parse(MText7.Text.ToString()),


                };
                netSellingInfo.UpdateNetSellingInfo(netSellingInfo, MText4.Text.ToString(), MText5.Text.ToString());
                MessageBox.Show("Record successfully updated.");
            }
            if (NAddButton.Text == "Check Out"
                & MainTab1.Text == "New Customer"
                & Main_Running_Control.Text == " -   ( Enter customer's information )")
            {
                if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Cnic length is not valid.");
                    return;
                }
                if (MText4.TextLength != 11)
                {
                    MessageBox.Show("Phone length is not valid.");
                    return;
                }
                if (MText4.Text == "")
                {
                    MessageBox.Show("Phone number must be required.");
                    return;
                }
                if (MText5.Text == "")
                {
                    MessageBox.Show("Engine must be required.");
                    return;
                }
                if (MText7.Text == "")
                {
                    MessageBox.Show("Date must be required.");
                    return;
                }
                if (MText6.Text == "")
                {
                    MessageBox.Show("Amount must be required.");
                    return;
                }
                NetSellingInfo netSellingInfo = new NetSellingInfo
                {
                    CCnic = MText1.Text.ToString(),
                    CName = MText2.Text.ToString(),
                    CAddress = MText3.Text.ToString(),
                    CPhone = MText4.Text.ToString(),
                    SEngineNo = MText5.Text.ToString(),
                    CAmount = Int32.Parse(MText6.Text.ToString()),
                    CDate = DateTime.Parse(MText7.Text.ToString())
                };
                StockInfo stockInfo = new StockInfo();
                if (stockInfo.StockValidation(MText5.Text.ToString()) == true)
                {
                    if (netSellingInfo.Validation(MText4.Text.ToString(), MText5.Text.ToString()) == false)
                    {
                        netSellingInfo.InsertNetSellingInfo(netSellingInfo);
                        MessageBox.Show("Record addedd sucessfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record already exist with this Phone and Engine No.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("There is no stock with this Engine No.");
                    return;
                }
            }
            if (NAddButton.Text == "Delete"
                & Main_Running_Control.Text == " -   ( Delete Customer's Information )")
            {
                NetSellingInfo netSellingInfo = new NetSellingInfo();
                netSellingInfo.DeleteNetSellingInfo(MText4.Text.ToString(), MText5.Text.ToString());
                MessageBox.Show("Record has been deleted successfully.");
            }
        }

        private void MainTab4_Click(object sender, EventArgs e)
        {
            if (MainTab4.Text == "All Outsider Leases")
            {
                ResetAll();
                MainTab3.Show();
                MainTab4.Show();
                MainTab1.Show();
                MainTab2.Show();
                MLabel1.Show();
                MSearchButton.Show();
                MLabel1.Text = "If you click check button then all information of all outsider leases will show.";
                MText1.Hide();
                MSearchButton.Text = "Check";
            }
        }




        private void CrossButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MAddButton_Click(object sender, EventArgs e)
        {
            if (MainTab1.Text == "Date Wise"
                & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Track Member Committee )")
            {
                BMember_Click(BMember, EventArgs.Empty);
            }
            if (MAddButton.Text == "Back"
                 & Main_Running_Control.Text == " -   ( Show Member's Information )")
            {
                BShowMInfo_Click(BShowMInfo, EventArgs.Empty);
            }
            if (MainTab1.Text == "Update" & MainTab1.selected == true
                & Main_Running_Control.Text == " -   ( Modify Committee Entry )"
                & MAddButton.Text == "Update")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();

                if (sQLHelpers.GetMembersInfo(MText1.Text, MText2.Text) != null)
                {
                    int camount;
                    if (MComboBox2.Text == "Daily")
                    {
                        camount = 50;
                    }
                    else if (MComboBox2.Text == "Monthly")
                    {
                        camount = 1500;
                    }
                    else
                    {
                        camount = 0;
                        MessageBox.Show("Please select committee type.");
                        return;
                    }
                    CommitteeInfo committeeInfo = new CommitteeInfo
                    {
                        MPhone = MText1.Text,
                        MName = MText2.Text,
                        CAmount = camount,
                        DDate = DateTime.Now.Date,
                        CDate = DateTime.Parse((MText4.Text))
                    };

                    if (committeeInfo.CheckExistence(committeeInfo) == false)
                    {

                        committeeInfo.UpdateCommitteInfo(camount, CMPhone, CMName, CCDate);
                        MessageBox.Show("Committe successfully Updated.");
                        BModifyCommittee_Click(BModifyCommittee, EventArgs.Empty);

                    }
                    else
                    {
                        MessageBox.Show("Committee already exist.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Member not exist");
                    return;
                }
            }
            if (MainTab2.Text == "Delete" & MainTab2.selected == true
               & Main_Running_Control.Text == " -   ( Modify Committee Entry )"
               & MAddButton.Text == "Delete")
            {
                CommitteeInfo committeeInfo = new CommitteeInfo();
                committeeInfo.DeleteExpensesInfo(MText1.Text.ToString(), MText2.Text.ToString(), DateTime.Parse(MText4.Text.ToString()));
                MessageBox.Show("Committee successfully deleted.");
                MainTab2_Click(MainTab2, EventArgs.Empty);
            }
            if (MainTab1.Text == "Enter"
            & Main_Running_Control.Text == " -   ( Committee Entry )"
            & MAddButton.Text == "Add")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                if (sQLHelpers.GetMembersInfo(MText1.Text, MText2.Text) != null)
                {
                    int camount;
                    if (MComboBox2.Text == "Daily")
                    {
                        camount = 50;
                    }
                    else if (MComboBox2.Text == "Monthly")
                    {
                        camount = 1500;
                    }
                    else
                    {
                        camount = 0;
                        MessageBox.Show("Please select committee type.");
                        return;
                    }
                    CommitteeInfo committeeInfo = new CommitteeInfo
                    {
                        MPhone = MText1.Text,
                        MName = MText2.Text,
                        CAmount = camount,
                        DDate = DateTime.Now.Date,
                        CDate = DateTime.Parse((MText4.Text))
                    };

                    if (committeeInfo.GetCommitteeInfo(committeeInfo.MPhone, committeeInfo.MName,
                        committeeInfo.CDate) == null)
                    {

                        committeeInfo.InsertCommitteeInfo(committeeInfo);
                        MessageBox.Show("Committe successfully entered");
                        BEnterCommittee_Click(BEnterCommittee, EventArgs.Empty);


                    }
                    else
                    {
                        MessageBox.Show("Committee already entered");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Member not exist");
                    return;
                }
            }
            if (MainTab1.Text == "New Member"
                & Main_Running_Control.Text == " -   ( Enter new member's information )"
                & MAddButton.Text == "Add")
            {
                if (MText2.Text == "" || MText4.Text == "")
                {
                    MessageBox.Show("Error: Phone and Name must be required.");
                    return;
                }
                else if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Error: Cnic length or formate is not valid.");
                    return;
                }
                else if (MText2.TextLength > 25)
                {
                    MessageBox.Show("Error: Name must have less than 25 characters.");
                    return;
                }
                else if (MText4.TextLength != 11)
                {
                    MessageBox.Show("Error: Phone number length or formate is not valid.");
                    return;
                }
                else if (MText3.TextLength > 100)
                {
                    MessageBox.Show("Error: Address must be less than 100 characters.");
                    return;
                }

                MembersInfo membersInfo = new MembersInfo
                {
                    MCnic = MText1.Text,
                    MName = MText2.Text,
                    MAddress = MText3.Text,
                    MPhone = MText4.Text
                };
                using (SQLHelpers sQLHelpers = new SQLHelpers())
                {
                    sQLHelpers.InsertMembersInfo(membersInfo);
                    MessageBox.Show("Record Enterd");
                    BNewMember_Click(BMembersInfo, EventArgs.Empty);
                }

            }
            if (MainTab1.Text == "Update Member"
                & Main_Running_Control.Text == " -   ( Update Member's Information )"
                & MAddButton.Text == "Update")
            {
                if (MText2.Text == "" || MText4.Text == "")
                {
                    MessageBox.Show("Error: Phone and Name must be required.");
                    return;
                }
                else if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Error: Cnic length or formate is not valid.");
                    return;
                }
                else if (MText2.TextLength > 25)
                {
                    MessageBox.Show("Error: Name must have less than 25 characters.");
                    return;
                }
                else if (MText4.TextLength != 11)
                {
                    MessageBox.Show("Error: Phone number length or formate is not valid.");
                    return;
                }
                else if (MText3.TextLength > 100)
                {
                    MessageBox.Show("Error: Address must be less than 100 characters.");
                    return;
                }
                MembersInfo membersInfo = new MembersInfo
                {
                    MCnic = MText1.Text,
                    MName = MText2.Text,
                    MAddress = MText3.Text,
                    MPhone = MText4.Text
                };
                SQLHelpers sQLHelpers = new SQLHelpers();
                sQLHelpers.UpdateMembersInfo(membersInfo, CMembersInfo.MName, CMembersInfo.MPhone);
                MessageBox.Show("Record updated successfully.");
                BUpdateMember_Click(BUpdateMember, EventArgs.Empty);
            }
            if (MainTab1.Text == "Delete Member"
                & Main_Running_Control.Text == " -   ( Delete Member's Information )"
                & MAddButton.Text == "Delete")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                sQLHelpers.DeleteMembersInfo(MText4.Text.ToString(), MText2.Text.ToString());
                MessageBox.Show("Member deleted successfully");
                BDeleteMember_Click(BDeleteMember, EventArgs.Empty);
            }
        }
        private void SAddButton_Click(object sender, EventArgs e)
        {
            if (SAddButton.Text == "Delete" & Main_Running_Control.Text == " -   ( Delete lease information )")
            {
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo();
                outsiderLeasesInfo.DeleteOutsiderLeasesInfo(MText4.Text.ToString(), MText5.Text.ToString());
                MessageBox.Show("The record successfully deleted.");

            }
            if (MainTab2.Text == "For Outsider" & Main_Running_Control.Text == " -   ( Enter new lease information )")
            {
                if (MText4.Text == "")
                {
                    MessageBox.Show("Phone must be required.");
                    return;
                }

                if (MText5.Text == "")
                {
                    MessageBox.Show("Engine must be required.");
                    return;
                }

                StockInfo stockInfo = new StockInfo();

                if (stockInfo.StockValidation(MText5.Text.ToString()) == false)
                {

                    MessageBox.Show("There is no stock found against this Engine No.");
                    return;
                }
                if (MText4.TextLength != 11)
                {
                    MessageBox.Show("Provided phone number is too short.");
                    return;
                }
                if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Provided cnic number is too short.");
                    return;
                }
                if (MText10.TextLength != 10)
                {
                    MessageBox.Show("Provided date is too short.");
                    return;
                }
                if (MText7.Text == "")
                {
                    MessageBox.Show("Amount must be required");
                    return;
                }
                if (MText10.Text == "")
                {
                    MessageBox.Show("Date must be required");
                    return;
                }
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo
                {
                    OLCnic = MText1.Text.ToString(),
                    OLName = MText2.Text.ToString(),
                    OLAddress = MText3.Text.ToString(),
                    OLPhone = MText4.Text.ToString(),
                    SEngineNo = MText5.Text.ToString(),
                    OLAdvance = Int32.Parse(MText6.Text.ToString()),
                    OLAmount = Int32.Parse(MText7.Text.ToString()),
                    OLDuration = Int32.Parse(MText8.Text.ToString()),
                    OLInstallment = Int32.Parse(MText9.Text.ToString()),
                    OLDate = DateTime.Parse(MText10.Text.ToString()),

                };

                if (!outsiderLeasesInfo.Validation(MText4.Text.ToString(), MText5.Text.ToString()))
                {
                    outsiderLeasesInfo.InsertOutsiderLeasesInfo(outsiderLeasesInfo);
                    MessageBox.Show("Record successfully added.");
                }
                else
                {
                    MessageBox.Show("Record already exist , duplication not allowed.");
                    return;
                }

            }
            if (SAddButton.Text == "Delete" & Main_Running_Control.Text == " -   ( Delete Stock Record )")
            {
                StockInfo stockInfo = new StockInfo();
                stockInfo.DeleteRcord(MText1.Text);
                MessageBox.Show("Record deleted successfully.");
                BUpdate_Click(BUpdate, EventArgs.Empty);
            }
            if (SAddButton.Text == "Update" & Main_Running_Control.Text == " -   ( Update Stock Record )")
            {
                if (MText1.Text == "")
                {
                    MessageBox.Show("Engine No. must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Chassis No. must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Company name must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Model must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Amount must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Date must be required.");
                    return;
                }
                StockInfo stockInfo = new StockInfo()
                {
                    SEngineNo = MText1.Text,
                    SChassisNo = MText2.Text,
                    SCompany = MText3.Text,
                    SModel = MText4.Text,
                    SAmount = Int32.Parse(MText5.Text),
                    SRegNo = MText6.Text,
                    SFileNo = MText7.Text,
                    SDate = DateTime.Parse(MText8.Text),


                };
                if (MCheck1.Checked)
                    stockInfo.CopyRecived = 1;
                else
                    stockInfo.CopyRecived = 0;
                if (MCheck2.Checked)
                    stockInfo.LetterRecived = 1;
                else
                    stockInfo.LetterRecived = 0;
                try { stockInfo.UpdateRecord(stockInfo, CSEngine); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Record updated successfully.");
                BUpdate_Click(BUpdate, EventArgs.Empty);
            }
            if (SAddButton.Text == "Add" & Main_Running_Control.Text == " -   ( Enter new record's information )")
            {
                SQLHelpers sQLHelpers = new SQLHelpers();
                if (MText1.Text == "")
                {
                    MessageBox.Show("Engine No. must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Chassis No. must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Company name must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Model must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Amount must be required.");
                    return;
                }
                if (MText1.Text == "")
                {
                    MessageBox.Show("Date must be required.");
                    return;
                }
                StockInfo stockInfo = new StockInfo()
                {
                    SEngineNo = MText1.Text,
                    SChassisNo = MText2.Text,
                    SCompany = MText3.Text,
                    SModel = MText4.Text,
                    SAmount = Int32.Parse(MText5.Text),
                    SRegNo = MText6.Text,
                    SFileNo = MText7.Text,
                    SDate = DateTime.Parse(MText8.Text),


                };
                if (stockInfo.StockValidation(MText1.Text))
                {
                    MessageBox.Show("Record with this engine number already exists.");
                    return;
                }

                if (MCheck1.Checked)
                    stockInfo.CopyRecived = 1;
                else
                    stockInfo.CopyRecived = 0;
                if (MCheck2.Checked)
                    stockInfo.LetterRecived = 1;
                else
                    stockInfo.LetterRecived = 0;

                stockInfo.InsertStockInfo(stockInfo);
                MessageBox.Show("Record entered successfully.");


            }
            if (SAddButton.Text == "Update" & Main_Running_Control.Text == " -   ( Update lease information )")
            {
                if (MText1.TextLength != 15)
                {
                    MessageBox.Show("Provided cnic number is too short.");
                    return;
                }
                if (MText10.TextLength != 10)
                {
                    MessageBox.Show("Provided date is too short.");
                    return;
                }
                if (MText7.Text == "")
                {
                    MessageBox.Show("Amount must be required");
                    return;
                }
                if (MText10.Text == "")
                {
                    MessageBox.Show("Date must be required");
                    return;
                }
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo
                {
                    OLCnic = MText1.Text.ToString(),
                    OLName = MText2.Text.ToString(),
                    OLAddress = MText3.Text.ToString(),
                    OLPhone = MText4.Text.ToString(),
                    SEngineNo = MText5.Text.ToString(),
                    OLAdvance = Int32.Parse(MText6.Text.ToString()),
                    OLAmount = Int32.Parse(MText7.Text.ToString()),
                    OLDuration = Int32.Parse(MText8.Text.ToString()),
                    OLInstallment = Int32.Parse(MText9.Text.ToString()),
                    OLDate = DateTime.Parse(MText10.Text.ToString()),

                };
                outsiderLeasesInfo.UpdateOutsiderLeasesInfo(outsiderLeasesInfo,
                    MText4.Text.ToString(), MText5.Text.ToString());
                MessageBox.Show("Record successfully updated.");

            }
        }
    }
}