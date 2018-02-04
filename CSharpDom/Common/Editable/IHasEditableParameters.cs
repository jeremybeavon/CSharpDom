using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableParameters<TParameter> : IHasParameters<TParameter>
    {
        new IList<TParameter> Parameters { get; set; }
    }
}