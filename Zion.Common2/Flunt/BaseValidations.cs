using System.Collections.Generic;
using System.Linq;

namespace Zion.Common2.Flunt
{
    public abstract class BaseValidations
    {
        private List<Validation> _validations = new List<Validation>();

        public IReadOnlyCollection<Validation> Validations { get { return _validations; } }

        public void AddValidation(string property, string message)
        {
            _validations.Add(new Validation(property, message));
        }

        public void AddValidation(Validation validation)
        {
            _validations.Add(validation);
        }

        public void AddValidations(IReadOnlyCollection<Validation> validations)
        {
            _validations.AddRange(validations);
        }

        public void AddNotifications(IList<Validation> validations)
        {
            _validations.AddRange(validations);
        }

        public void AddNotifications(ICollection<Validation> validations)
        {
            _validations.AddRange(validations);
        }

        public void RemoveValidation(Validation validation)
        {
            _validations.Remove(validation);
        }

        public void RemoveValidation(string property)
        {
            _validations.RemoveAll(x => x.Property == property);
        }

        public void RemoveAllValidations()
        {
            foreach (var notification in _validations)
            {
                _validations.Remove(notification);
            }
        }

        public bool Invalid => _validations.Any();
        public bool Valid => !Invalid;
    }
}
