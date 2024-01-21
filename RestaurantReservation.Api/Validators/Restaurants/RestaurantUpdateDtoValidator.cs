using FluentValidation;
using RestaurantReservation.Api.Models.Restaurants;

namespace RestaurantReservation.Api.Validators.Restaurants;

public class RestaurantUpdateDtoValidator : AbstractValidator<RestaurantUpdateDto>
{
  public RestaurantUpdateDtoValidator()
  {
    RuleLevelCascadeMode = CascadeMode.Stop;
    
    RuleFor(x => x.Address)
      .NotEmpty();

    RuleFor(x => x.Name)
      .NotEmpty()
      .ValidName();

    RuleFor(x => x.OpeningHours)
      .NotEmpty();

    RuleFor(x => x.PhoneNumber)
      .ValidPhoneNumber();
  }
}