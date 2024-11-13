using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("Nome pode ser de no máximo 50 caracteres.");

            RuleFor(c => c.Preco)
                .NotEmpty().WithMessage("Por favor informe o preço.")
                .NotNull().WithMessage("Por favor informe o preço.");

            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.");

            RuleFor(c => c.DataCompra)
                .NotEmpty().WithMessage("Por favor informe a data da compra.")
                .NotNull().WithMessage("Por favor informe a data da compra.");

            RuleFor(c => c.UnidadeVenda)
                .NotEmpty().WithMessage("Por favor informe a unidade de venda.")
                .NotNull().WithMessage("Por favor informe a unidade de venda.")
                .MaximumLength(10).WithMessage("Unidade de venda pode ser de no máximo 10 caracteres.");

        }
    }
}
