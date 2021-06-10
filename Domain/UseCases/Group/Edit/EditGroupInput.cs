using Domain.Abstractions.Mediator;
using FluentValidation;

namespace Domain.UseCases.Group.Edit
{
    public class EditGroupInput: IUseCaseInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class EditGroupInputValidator: AbstractValidator<EditGroupInput>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}