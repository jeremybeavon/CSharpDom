using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class LoadedDocumentFactory : AbstractFactory<ILoadedDocument, LoadedDocument>
    {
        public LoadedDocumentFactory(ILoadedDocument loadedDocument)
            : base(loadedDocument)
        {
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedDocument)
        {
            Value = new LoadedDocument()
            {
                AssemblyAttributes = loadedDocument.AssemblyAttributes.ToAttributeListUsingFactory(),
                Classes = new ClassCollectionFactory(loadedDocument.Classes).Value,
                Delegates = loadedDocument.Delegates.ToList(@delegate => new DelegateFactory(@delegate).Value),
                Enums = loadedDocument.Enums.ToList(@enum => new EnumFactory(@enum).Value),
                Interfaces = new InterfaceCollectionFactory(loadedDocument.Interfaces).Value,
                ModuleAttributes = loadedDocument.ModuleAttributes.ToAttributeListUsingFactory(),
                Namespaces = loadedDocument.Namespaces.ToList(@namespace => new NamespaceFactory(@namespace).Value),
                Structs = new StructCollectionFactory(loadedDocument.Structs).Value,
                UsingDirectives = loadedDocument.UsingDirectives.ToList(@using => new UsingDirectiveFactory(@using).Value)
            };
        }
    }
}
