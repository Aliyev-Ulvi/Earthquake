using Entities.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class AuthValidator : AbstractValidator<RegisterDto>
    {
        public AuthValidator()
        {
            RuleFor(u => u.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Boş göndərilə bilməz")
                .MinimumLength(3).WithMessage("Minimum 3 simvol olmalıdır");

            RuleFor(u => u.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Boş göndərilə bilməz")
                .MinimumLength(3).WithMessage("Minimum 3 simvol olmalıdır");

            RuleFor(u => u.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Boş göndərilə bilməz")
                .Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$").When(a => !string.IsNullOrEmpty(a.Email)).WithMessage("Email düzgün formatda deyil (nümunə: user@domain.com)");

            RuleFor(u => u.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Boş göndərilə bilməz")
                .Matches("[A-Z]").WithMessage("Mütləq şəkildə böyük simvol istifadə olunmalıdır")
                .Matches("[a-z]").WithMessage("Mütləq şəkildə kiçik simvol istifadə olunmalıdır")
                .Matches("[0-9]").WithMessage("Mütləq şəkildə rəqəmlərdən istifadə olunmalıdır");

            RuleFor(u => u.RePassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Boş göndərilə bilməz")
                .Equal(u => u.Password).WithMessage("Parollar bir-biri ilə eyni olmalıdır");
        }
    }
}
