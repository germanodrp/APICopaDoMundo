using APICopaDoMundo.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace APICopaDoMundo.Validation
{
    public class PaisesVallidation: AbstractValidator<Paises>
    {
        public PaisesVallidation()
        {
            RuleFor(Paises => Paises.Id)
                .NotEmpty().WithMessage("Campo paises vazio,tente novamente")
                .NotNull().WithMessage("Campo paises não informado, tente novamente !");

            RuleFor(Paises => Paises.Nome)
                .NotEmpty().WithMessage("Campo paises vazio,tente novamente")
                .NotNull().WithMessage("Campo paises não informado, tente novamente !")
                .MinimumLength(2).WithMessage("Minimo 2 caracteres")
                .Must(SomenteLetras).WithMessage("Somente Letras");

            RuleFor(Paises => Paises.RankingFifa)
                .NotEmpty().WithMessage("Campo paises vazio,tente novamente")
                .NotNull().WithMessage("Campo paises não informado, tente novamente !");
                

         

        }
        public static bool SomenteNumero(string Numeros)
        {
            //logica da receita
            return Regex.IsMatch(Numeros, @"^\d$");

        }
        public static bool SomenteLetras(string palavra)
        {
            return Regex.IsMatch(palavra, @"^[a-zA-Z]+$");
        }
    }
}
