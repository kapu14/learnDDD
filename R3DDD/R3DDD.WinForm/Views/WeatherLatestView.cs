using R3DDD.Infrastructure;
using R3DDD.WinForm.ViewModels;
using System.Windows.Forms;

namespace R3DDD.WinForm.Views
{
    public partial class WeatherLatestView : Form
    {
        private WeatherLatestViewModel _viewModel = new WeatherLatestViewModel();
        public WeatherLatestView()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif 

            AreaIdTextbox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AreaIdText));

            AreaNameTextbox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.AreaNameText));

            ConditionTextbox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ConditionText));

            DataDateTextbox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.DataDateText));

            temperatureTextbox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.TemperatureText));




        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            _viewModel.Search();
        }


    }
}
