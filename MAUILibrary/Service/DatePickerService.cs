using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUILibrary.Object;

namespace MAUILibrary.Service
{
    public class DatePickerService
    {
        public event Action<ODatePicker, Dictionary<string, double>> RenderDatePickerDialog;

        public event Action<ODatePicker> UpdateDatePicker;
        public void RenderDatePicker(ODatePicker value , Dictionary<string, double> sourceRect)
        {
            RenderDatePickerDialog?.Invoke(value, sourceRect);
        }

        public void updateDatePicker(ODatePicker value)
        {
            UpdateDatePicker?.Invoke(value);
        }
    }
}
