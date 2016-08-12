using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NamespaceWrapper : AbstractWrapper<INamespace>
    {
        public NamespaceWrapper(INamespace @namespace)
            : base(@namespace)
        {
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> @namespace)
        {
            Value = new Namespace()
            {
                Classes = new ClassCollectionWrapper(@namespace.Classes).Value,
                Delegates = @namespace.Delegates.ToList(@delegate => new DelegateWrapper(@delegate).Value),
                Enums = @namespace.Enums.ToList(@enum => new EnumWrapper(@enum).Value),
                Interfaces = new InterfaceCollectionWrapper(@namespace.Interfaces).Value,
                Name = @namespace.Name,
                Namespaces = @namespace.Namespaces.ToList(inner => new NamespaceWrapper(inner).Value),
                Structs = new StructCollectionWrapper(@namespace.Structs).Value,
                UsingDirectives = @namespace.UsingDirectives.ToList(@using => new UsingDirectiveWrapper(@using).Value)
            };
        }
    }
}
