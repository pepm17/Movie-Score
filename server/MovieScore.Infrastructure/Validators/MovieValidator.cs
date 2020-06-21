using FluentValidation;
using MovieScore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieScore.Infrastructure.Validators
{
    public class MovieValidator: AbstractValidator<MovieDto>
    {
        public MovieValidator()
        {
            RuleFor(movie => movie.Description)
             .NotNull();
            RuleFor(movie => movie.Title)
             .NotNull();

        }
    }
}
