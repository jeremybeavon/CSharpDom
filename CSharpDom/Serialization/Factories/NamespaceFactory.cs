﻿using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NamespaceFactory : AbstractFactory<INamespace, Namespace>
    {
        public NamespaceFactory(INamespace @namespace)
            : base(@namespace)
        {
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
        {
            Value = new Namespace()
            {
                Classes = new ClassCollectionFactory(@namespace.Classes).Value,
                Delegates = @namespace.Delegates.ToList(@delegate => new DelegateFactory(@delegate).Value),
                Enums = @namespace.Enums.ToList(@enum => new EnumFactory(@enum).Value),
                Interfaces = @namespace.Interfaces.ToList(@interface => new InterfaceFactory(@interface).Value),
                Name = @namespace.Name,
                Namespaces = @namespace.Namespaces.ToList(inner => new NamespaceFactory(inner).Value),
                Structs = new StructCollectionFactory(@namespace.Structs).Value,
                UsingDirectives = @namespace.UsingDirectives.ToList(@using => new UsingDirectiveFactory(@using).Value)
            };
        }
    }
}
