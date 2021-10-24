using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Models {
    
    public class LessonsPerCycleValidator : ValidationAttribute {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is string { Length: > 0 }) {
                return null;
            }
            return new ValidationResult($"The lessons per cycle ",
                new []{validationContext.MemberName});
        }
    }
}