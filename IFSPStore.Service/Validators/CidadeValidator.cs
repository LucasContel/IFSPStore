using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class CidadeValidator : AbstractValidator<Cidade>
    {
        public CidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("Nome pode ser de no máximo 50 caracteres.");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Por favor informe o estado.")
                .NotNull().WithMessage("Por favor informe o estado.")
                .MaximumLength(50).WithMessage("Estado pode ser de no máximo 50 caracteres.");
        }

    }
}
