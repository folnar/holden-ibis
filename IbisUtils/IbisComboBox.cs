using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StringExtensionsSpace
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this String value)
        {
            if (value == null) return true;
            return string.IsNullOrEmpty(value.Trim());
        }
    }
}

namespace IbisUtils
{
    using StringExtensionsSpace;

    public partial class IbisComboBox : ComboBox
    {
        private bool _IsInNewStringMode;
        private bool _IsInExistingEditMode;
        private bool _IsInSearchMode;
        private DataTable dt { get; set; }
        public string srchdtxt { get; set; }
        private string LabelColumn { get; set;}
        private string ValueColumn { get; set; }
        public bool IsInNewStringMode {
            get
            {
                return this._IsInNewStringMode;
            }
            set
            {
                this._IsInNewStringMode = value;
                this._IsInExistingEditMode = false;
                this._IsInSearchMode = false;
            }
        }
        public bool IsInExistingEditMode {
            get
            {
                return this._IsInExistingEditMode;
            }
            set
            {
                this._IsInExistingEditMode = value;
                this._IsInNewStringMode = false;
                this._IsInSearchMode = false;
            }
        }
        public bool IsInSearchMode {
            get
            {
                return this._IsInSearchMode;
            }
            set
            {
                this._IsInSearchMode = value;
                this._IsInExistingEditMode = false;
                this._IsInNewStringMode = false;
            }
        }

        public IbisComboBox()
        {
            dt = new DataTable();
            this.TextChanged += IbisComboBox_TextChanged;
            IsInNewStringMode = false;
        }

        public void Initialize(MySqlConnection dbh, string qry, string lblcol, string valcol)
        {
            srchdtxt = "";

            using (MySqlDataAdapter da = new MySqlDataAdapter(qry, dbh))
            {
                da.Fill(dt);

                DataSource = dt.DefaultView;
                DisplayMember = lblcol;
                ValueMember = valcol;

                LabelColumn = lblcol;
                ValueColumn = valcol;
            }

            SelectedIndex = -1;
        }

        public void Initialize(string qry, string lblcol, string valcol)
        {
            srchdtxt = "";

            using (MySqlConnection dbh = new MySqlConnection(Resource1.DB_CONNSTR_HES))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(qry, dbh))
                {
                    da.Fill(dt);

                    DataSource = dt.DefaultView;
                    DisplayMember = lblcol;
                    ValueMember = valcol;

                    LabelColumn = lblcol;
                    ValueColumn = valcol;
                }
            }

            SelectedIndex = -1;
        }

        public void Initialize(DataTable dtIn, string lblcol, string valcol)
        {
            srchdtxt = "";
            dt = dtIn;

            DataSource = dt.DefaultView;
            DisplayMember = lblcol;
            ValueMember = valcol;

            LabelColumn = lblcol;
            ValueColumn = valcol;

            SelectedIndex = -1;
        }

        public void Initialize(DataTable dtIn, string lblcol, string valcol, string sortcol)
        {
            srchdtxt = "";
            dt = dtIn;

            DataView dv = dt.DefaultView;
            dv.Sort = sortcol;
            DataSource = dv;
            DisplayMember = lblcol;
            ValueMember = valcol;

            LabelColumn = lblcol;
            ValueColumn = valcol;

            SelectedIndex = -1;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void IbisComboBox_TextChanged(object sender, EventArgs e)
        {
            if (IsInNewStringMode || IsInExistingEditMode) return;
            if (SelectedIndex == -1)
            {
                String s = Text;
                if (s.IsNullOrWhiteSpace())
                {
                    srchdtxt = "";
                }
                else
                {
                    srchdtxt = Text;
                    DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
                int caretpos = SelectionStart;
                if (!DisplayMember.Equals(""))
                {
                    dt.DefaultView.RowFilter = DisplayMember + " LIKE '%" + srchdtxt + "%'";
                }
                Text = srchdtxt;
                Select(caretpos + 1, 0);
            }
            if (Items.Count == 0)
            {
                dt.DefaultView.RowFilter = "";
                SelectedIndex = -1;
                DroppedDown = false;
            }
        }

        //internal void _updateAC()
        //{
        //    AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection autocompstrs = new AutoCompleteStringCollection();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        autocompstrs.Add(row.Field<string>(DisplayMember));
        //    }
        //    AutoCompleteCustomSource = autocompstrs;
        //}

        public void ResetSearch()
        {
            dt.DefaultView.RowFilter = "";
            srchdtxt = "";
            IsInSearchMode = true;
        }
    }
}
