using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStaticClasses<TStaticClass> : IHasStaticClasses<TStaticClass>
    {
        new ICollection<TStaticClass> StaticClasses { get; set; }
    }
}