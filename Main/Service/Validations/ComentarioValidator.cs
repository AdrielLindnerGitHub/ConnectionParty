using Domains;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class ComentarioValidator : AbstractValidator<Comentario>
    {
        public ComentarioValidator()
        {
            RuleFor(c => c.Texto).NotEmpty().MaximumLength(240).WithMessage("Comentário deve conter no máximo 240");
        }
    }
}
