using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Models {
    
    public class LessonsPerCycleValidator : ValidationAttribute {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is int and > 0 and <= 70) {
                return null;
            }
            return new ValidationResult($"The lessons per cycle must be greater than 0 and less than or equal to 70",
                new []{validationContext.MemberName});
        }
    }
}