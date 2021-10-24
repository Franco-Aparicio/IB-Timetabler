using System;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.BaseComponents {
    
    public class DateTimeBaseComponent : ComponentBase {

        public DateTime dateTime { get; } = DateTime.Now;
    }
}