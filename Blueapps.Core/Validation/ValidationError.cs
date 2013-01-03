using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blueapps.Core.Validation
{
    /// <summary>
    /// Validation Error Contract
    /// </summary>
    public interface IValidationError
    {
        string Field { get; }
        string Error { get; }
    }

    /// <summary>
    /// Validation Errors Collection Contract
    /// </summary>
    public interface IValidationErrors : ICollection<IValidationError>
    {
        bool IsValid { get; }
        void Add(string field, string error);
    }

    ///// <summary>
    ///// Validation Errors Collection Contract
    ///// </summary>
    //public interface IValidationErrors : ICollection
    //{
    //    bool IsValid { get; }
    //    int Add(string field, string error);
    //    int Add(IValidationError error);
    //}

    /// <summary>
    /// Validation Error Class
    /// </summary>
    public class ValidationError : IValidationError
    {
        public ValidationError(string field, string error)
        {
            Field = field;
            Error = error;
        }

        #region IValidationError Members

        public string Field { get; private set; }
        public string Error { get; private set; }

        #endregion

        /// <summary>
        /// Field formatting heler used with ModelState validation.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static string FormatField(string prefix, string field)
        {
            if (string.IsNullOrWhiteSpace(prefix))
            {
                return string.IsNullOrWhiteSpace(field) ? "*" : field;
            }
            return string.IsNullOrWhiteSpace(field) ? prefix : string.Format("{0}.{1}", prefix, field);

            //if (prefix.CompareTo("*") == 0)
            //{
            //    return string.IsNullOrWhiteSpace(field) ? prefix : string.Format("{0}.{1}", prefix, field);
            //}


            //return string.Format("{0}.{1}", prefix, field);
        }
    }

    /// <summary>
    /// Validation Errors Collection Class
    /// </summary>
    public class ValidationErrors : List<IValidationError>, IValidationErrors
    {
        #region IValidationErrors Members

        public void Add(string field, string error)
        {
            this.Add(new ValidationError(field, error));
        }

        public bool IsValid
        {
            get { return this.Count == 0; }
        }

        #endregion
    }
}
