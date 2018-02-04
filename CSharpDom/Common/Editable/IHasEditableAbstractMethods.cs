using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractMethods<TMethod> : IHasAbstractMethods<TMethod>
    {
        new ICollection<TMethod> AbstractMethods { get; set; }
    }
}