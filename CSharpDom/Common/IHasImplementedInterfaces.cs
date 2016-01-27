using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasImplementedInterfaces<TInterfaceReference>
        where TInterfaceReference : IVisitable<IGenericVisitor>
    {
        IReadOnlyCollection<TInterfaceReference> ImplementedInterfaces { get; }
    }
}
