using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class LoadedDocumentFactory : AbstractFactory<ILoadedDocument, LoadedDocument>
    {
        public LoadedDocumentFactory(ILoadedDocument loadedDocument)
            : base(loadedDocument)
        {
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            Value = new LoadedDocument()
            {
                AssemblyAttributes = loadedDocument.AssemblyAttributes.ToAttributeListUsingFactory(),
                Classes = loadedDocument.Classes.ToList(@class => new ClassFactory(@class).Value),
                Delegates = loadedDocument.Delegates.ToList(@delegate => new DelegateFactory(@delegate).Value),
                Enums = loadedDocument.Enums.ToList(@enum => new EnumFactory(@enum).Value),
                Interfaces = loadedDocument.Interfaces.ToList(@interface => new InterfaceFactory(@interface).Value),
                ModuleAttributes = loadedDocument.ModuleAttributes.ToAttributeListUsingFactory(),
                Namespaces = loadedDocument.Namespaces.ToList(@namespace => new NamespaceFactory(@namespace).Value),
                Structs = loadedDocument.Structs.ToList(@struct => new StructFactory(@struct).Value),
                UsingDirectives = loadedDocument.UsingDirectives.ToList(@using => new UsingDirectiveFactory(@using).Value)
            };
        }
    }
}
