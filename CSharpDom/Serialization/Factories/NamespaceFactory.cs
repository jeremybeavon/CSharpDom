using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NamespaceFactory : AbstractFactory<INamespace, Namespace>
    {
        public NamespaceFactory(INamespace @namespace)
            : base(@namespace)
        {
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            Value = new Namespace()
            {
                Classes = @namespace.Classes.ToList(@class => new ClassFactory(@class).Value),
                Delegates = @namespace.Delegates.ToList(@delegate => new DelegateFactory(@delegate).Value),
                Enums = @namespace.Enums.ToList(@enum => new EnumFactory(@enum).Value),
                Interfaces = @namespace.Interfaces.ToList(@interface => new InterfaceFactory(@interface).Value),
                Name = @namespace.Name,
                Namespaces = @namespace.Namespaces.ToList(inner => new NamespaceFactory(inner).Value),
                Structs = @namespace.Structs.ToList(@struct => new StructFactory(@struct).Value),
                UsingDirectives = @namespace.UsingDirectives.ToList(@using => new UsingDirectiveFactory(@using).Value)
            };
        }
    }
}
