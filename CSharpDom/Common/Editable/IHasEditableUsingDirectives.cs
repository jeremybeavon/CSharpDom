using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableUsingDirectives<TUsingDirective> : IHasUsingDirectives<TUsingDirective>
    {
        new ICollection<TUsingDirective> UsingDirectives { get; set; }
    }
}