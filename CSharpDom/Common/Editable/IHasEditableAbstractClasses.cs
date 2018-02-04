using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAbstractClasses<TAbstractClass> : IHasAbstractClasses<TAbstractClass>
    {
        new ICollection<TAbstractClass> AbstractClasses { get; set; }
    }
}