using System;
using System.Collections.Generic;

namespace Solarizr.Models
{
    public class Appointment
    {
        public DateTime ScheduledDateTime { get; set; } = new DateTime(2017, 10, 16, 13, 15, 0);
        public string TimeRemaining { get; private set; } = "1 day, 12 hours, 2 minutes";
        public string AppointmentStatus { get; set; } = "Pending";
        public IList<string> AppointmentStatussen { get; private set; } = new List<string> { "Free", "Busy", "Pending" };
        public string Comments { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut laoreet interdum lectus, vitae mattis purus pellentesque cursus. Nunc ac orci quis lorem lobortis placerat. Nam ac massa tellus. Phasellus cursus lorem vitae tellus eleifend congue. Praesent nunc sem, scelerisque ac malesuada in, ullamcorper et augue. Maecenas et eros sit amet enim luctus eleifend in sit amet ex. Curabitur sed dictum nisl, non dictum magna. In non bibendum ante. Sed vel nisl viverra, fringilla mauris a, laoreet dui. Vivamus blandit sapien in risus consectetur posuere.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Nam sed enim vel sapien maximus dignissim.Morbi vel nulla convallis, facilisis diam vitae, tincidunt leo.Duis condimentum magna sit amet tincidunt posuere.Nullam ultrices velit risus, non pulvinar elit tincidunt ut.Donec vitae eros luctus, dapibus orci ac, tempor nisl. Fusce ipsum libero, congue sagittis sapien id, tincidunt molestie magna.Phasellus lobortis nisi ut nisl finibus accumsan.Nam venenatis sapien id lorem rutrum pretium.Donec ligula purus, dignissim sit amet mollis non, tincidunt vel ex.Aenean vehicula molestie augue, sed facilisis diam hendrerit id.Ut interdum tempor orci. Duis auctor varius felis a pretium.";
        public IList<string> PhotoUrls { get; private set; } = new List<string> { "/Assets/TestImage1.jpg", "/Assets/TestImage2.jpg", "/Assets/TestImage3.jpg", "/Assets/TestImage1.jpg", "/Assets/TestImage2.jpg", "/Assets/TestImage3.jpg", "/Assets/TestImage1.jpg", "/Assets/TestImage2.jpg", "/Assets/TestImage3.jpg" };

    }
}
