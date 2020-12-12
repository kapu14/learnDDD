using MYDDD.WinForm.Common;
using MYDDD.WinForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MYDDD.WinForm.Views
{
    public partial class WeatherLatestView : Form
    {

        public WeatherLatestView()
        {
            InitializeComponent();
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {

            var dt = WeatherSQL.GetLatest(Convert.ToInt32(this.AreaTextBox.Text));
            if (dt.Rows.Count > 0)
            {
                DataDateLabel.Text = dt.Rows[0]["DataDate"].ToString();
                ConditionLabel.Text = dt.Rows[0]["Condition"].ToString();
                TemperatureLabel.Text 
                    = CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"]), 
                    CommonConst.TemperatureDecimalPoint)
                           + CommonConst.TemperatureUnitName;
            }

        }




}
}
