using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUILibrary.Object
{
    public class ODatePicker
    {
        public DateTime PickedDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; }

        public bool StartDateSet { get; set; } = false;

        public DateTime EndDate { get; set; }

        public bool EndDateSet { get; set; } = false;
        public bool IsRangeDate { get; set; } = false;
        public bool Timepicker { get; set; } = false;
        public bool TimepickerRange { get; set; } = false;
        public bool ViewFromStart { get; set; } 

        public void AddRangeDate(DateTime date1 , DateTime date2)
        {
            if(date1 > date2)
            {
                StartDate = date1;
                EndDate = date2;
            }
            else
            {
                StartDate = date1;
                EndDate = date2;
            }
        }

        public void AddDate(DateTime date)
        {
           
            if (!this.EndDateSet && !this.StartDateSet)
            {
                this.StartDate = date;
                this.StartDateSet = true;
                
            }
            else if (this.EndDateSet && !this.StartDateSet)
            {
                if (date > EndDate)
                {
                    var temp = EndDate;
                    this.StartDate = temp;
                    this.EndDate = date;
                    this.StartDateSet = true;
                }
                else
                {
                    StartDate = date;
                    this.StartDateSet = true;
                }
            }
            else if(!this.EndDateSet && this.StartDateSet)
            {
                if (date < StartDate)
                {
                    var temp = this.StartDate;
                    this.EndDate = temp;
                    this.StartDate = date;
                    this.EndDateSet = true;
                }
                else
                {
                    EndDate = date;
                    this.EndDateSet = true;

                }
            }
            else
            {
                this.StartDate = date;
                this.StartDateSet = true;

                this.EndDate = new();
                this.EndDateSet = false;
            }
        }

       
    }
}
