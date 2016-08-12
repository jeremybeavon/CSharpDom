using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class LoadedDocumentWrapper : AbstractWrapper<ILoadedDocument>
    {
        public LoadedDocumentWrapper(ILoadedDocument loadedDocument)
            : base(loadedDocument)
        {
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> loadedDocument)
        {
            Value = new LoadedDocument()
            {
                AssemblyAttributes = loadedDocument.AssemblyAttributes.ToAttributeListUsingWrapper(),
                Classes = new ClassCollectionWrapper(loadedDocument.Classes).Value,
                Delegates = loadedDocument.Delegates.ToList(@delegate => new DelegateWrapper(@delegate).Value),
                Enums = loadedDocument.Enums.ToList(@enum => new EnumWrapper(@enum).Value),
                Interfaces = new InterfaceCollectionWrapper(loadedDocument.Interfaces).Value,
                ModuleAttributes = loadedDocument.ModuleAttributes.ToAttributeListUsingWrapper(),
                Namespaces = loadedDocument.Namespaces.ToList(@namespace => new NamespaceWrapper(@namespace).Value),
                Structs = new StructCollectionWrapper(loadedDocument.Structs).Value,
                UsingDirectives = loadedDocument.UsingDirectives.ToList(@using => new UsingDirectiveWrapper(@using).Value)
            };
        }
    }
}
