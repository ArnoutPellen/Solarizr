using Solarizr.Models;
using Template10.Mvvm;

namespace Solarizr.ViewModels
{
    public class DashboardPageViewModel : ViewModelBase
    {
        public string CurrentDate { get; set; } = "16-10-2017";
        public int NumberOfAppointments { get; } = 100;
        public Appointment NextAppointment { get; set; } = new Appointment();

    }
}
