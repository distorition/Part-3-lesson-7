using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part_3_Lesson_4
{
    public class UserAtribute:AbstractValidator<User>
    {
        public UserAtribute()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Имя не должно быть пустым").WithErrorCode("001");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("фамилия не может быть пустая").WithErrorCode("002");
        }
    }
}
