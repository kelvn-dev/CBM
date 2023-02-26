using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBM.Utilities {
  public class TimeUtils {

    public static DateTime GetCurrentTime() {
      return DateTime.Now;
    }

    public static string GetCurrentFormattedTime() {
      DateTime currentTime = DateTime.Now;
      int day = currentTime.Day;
      Console.WriteLine(day);
      int month = currentTime.Month;
      Console.WriteLine(month);
      int year = currentTime.Year;
      int hour = currentTime.Hour;
      int minute = currentTime.Minute;
      int second = currentTime.Second;
      string formatted = currentTime.ToString("dd/MM/yyyy HH:mm");
      Console.WriteLine(formatted);
      return formatted;
    }

  }
}
