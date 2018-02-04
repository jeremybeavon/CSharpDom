using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IHasEditablePartialClasses<TClass> : IHasPartialClasses<TClass>
    {
        new ICollection<TClass> Classes { get; set; }
    }
}