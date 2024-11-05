using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");

            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valor total.");

        }
    }

    public class VendaItemValidator : AbstractValidator<VendaItem>
    {
        public VendaItemValidator()
        {
            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe o quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.");

            RuleFor(c => c.ValorUnitario)
                .NotEmpty().WithMessage("Por favor informe o valor unitário.")
                .NotNull().WithMessage("Por favor informe o valor unitário.");

            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valot total.");


        }
    }
}
