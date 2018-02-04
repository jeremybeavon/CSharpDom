using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableOperatorOverloads<TOperatorOverload> : IHasOperatorOverloads<TOperatorOverload>
    {
        new ICollection<TOperatorOverload> OperatorOverloads { get; set; }
    }
}