using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableConstructors<TConstructor> : IHasConstructors<TConstructor>
    {
        new ICollection<TConstructor> Constructors { get; set; }
    }
}