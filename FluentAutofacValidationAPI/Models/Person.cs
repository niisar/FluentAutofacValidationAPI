using FluentValidation;

namespace FluentAutofacValidationAPI.Models
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string OtherNames { get; set; }
        public string LastName { get; set; }
    }
}