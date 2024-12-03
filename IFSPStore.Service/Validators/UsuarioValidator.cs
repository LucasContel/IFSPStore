using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(50).WithMessage("Nome pode ser de no máximo 50 caracteres.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.")
                .EmailAddress().WithMessage("E-mail inválido.");

            RuleFor(c => c.Senha)
                //.MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 digitos.")
                //.MaximumLength(20).WithMessage("Senha deve ter no máximo 20 digitos.")
                //.Matches(@"[A-Z]+").WithMessage("Sua senha deve conter pelo menos uma letra maiuscula.")
                //.Matches(@"[a-z]+").WithMessage("Sua senha deve conter pelo menos uma letra minuscula.")
                //.Matches(@"[0-9]+").WithMessage("Sua senha deve conter pelo menos um número.")
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.");
        }
    }
}
