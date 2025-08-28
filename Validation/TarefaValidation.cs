using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Validation
{
    public class TarefaValidation : AbstractValidator<Tarefa>
    {
        public TarefaValidation()
        {
            RuleFor(x => x.Data)
            .NotNull().WithMessage("A data da tarefa é obrigatoria.")
            .Must(data => data != default(DateTime)).WithMessage("Formato de data invalido.");

            RuleFor(x => x.Titulo)
            .NotEmpty().WithMessage("O titulo é obrigatorio.");

            RuleFor(x => x.Descricao)
            .NotEmpty().WithMessage("A descrição é obrigatorio.");
        }
    }
}