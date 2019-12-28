using DotNetCore.Validation;
using FluentValidation;

namespace HRMS.Model
{
    public class ItemListValidator<T> : Validator<T> where T : ItemListModel
    {
        public ItemListValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty();
        }
    }
}

