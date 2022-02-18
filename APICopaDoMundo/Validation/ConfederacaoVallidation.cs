using APICopaDoMundo.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace APICopaDoMundo.Validation
{
    public class ConfederacaoVallidation:AbstractValidator<Confederacoes>
    {
        public ConfederacaoVallidation()
        {
            RuleFor(Confederacoes => Confederacoes.Id)
                .NotEmpty().WithMessage("Campo confederações vazio,tente novamente ")
                .NotNull().WithMessage("Campo confederações não informado,tente novamente !");

            RuleFor(Confederacoes => Confederacoes.Sigla)
                .NotEmpty().WithMessage("Campo confederações vazio,tente novamente")
                .NotNull().WithMessage("Campo confederações não informado,tente novamente !")
                .MinimumLength(2).WithMessage("Minimo 3 caracteres")
                .Must(SomenteLetras).WithMessage("Somente Letras");


        }
        public static bool SomenteLetras(string palavra)
        {
            return Regex.IsMatch(palavra, @"^[a-zA-Z]+$");
        }
    }
}
