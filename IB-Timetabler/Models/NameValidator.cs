using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Models {
    
    public class NameValidator : ValidationAttribute {
        
        [Parameter]
        public List<Lesson> Classes { get; set; } // Get classes from database
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is string val && Classes.All(x => x.Name != val)) {
                return null;
            }
            return new ValidationResult($"Each lesson must have a unique name",
                new []{validationContext.MemberName});
        }
    }
}