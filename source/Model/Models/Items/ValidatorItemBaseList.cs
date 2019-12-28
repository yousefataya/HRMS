using DotNetCore.Validation;
using FluentValidation;

namespace HRMS.Model
{
    public class ValidatorItemBaseList<T> : ItemListValidator<ItemListModel>
    {
        public ValidatorItemBaseList()
        {
            RuleFor(x => x.CreateDate).NotEmpty();
        }
    }
}
