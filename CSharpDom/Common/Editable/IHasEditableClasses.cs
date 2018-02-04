using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClasses<TClass> : IHasClasses<TClass>
    {
        new ICollection<TClass> Classes { get; set; }
    }
}