using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace IB_Timetabler.Models {
    
    public class TextValidator : ValidationAttribute {
        
        [Parameter]
        public string Field { get; set; } 
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is string { Length: > 0 }) {
                return null;
            }
            return new ValidationResult($"The lesson must have a {Field}",
                new []{validationContext.MemberName});
        }
    }
}