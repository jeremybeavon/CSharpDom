using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CSharpDom.Internal
{
    internal sealed class AnalyzedDocument
    {
        public AnalyzedDocument(DocumentNode document, IEnumerable<NamespaceNode> namespaces)
        {
            Document = document;
            Namespaces = namespaces;
        }

        public DocumentNode Document { get; private set; }

        public IEnumerable<NamespaceNode> Namespaces { get; private set; }

        public IEnumerable<ClassNode> Classes
        {
            get { return Namespaces.SelectMany(@namespace => @namespace.Classes); }
        }

        public IEnumerable<DelegateNode> Delegates
        {
            get { return Namespaces.SelectMany(@namespace => @namespace.Delegates); }
        }

        public IEnumerable<EnumNode> Enums
        {
            get { return Namespaces.SelectMany(@namespace => @namespace.Enums); }
        }

        public IEnumerable<InterfaceNode> Interfaces
        {
            get { return Namespaces.SelectMany(@namespace => @namespace.Interfaces); }
        }

        public IEnumerable<StructNode> Structs
        {
            get { return Namespaces.SelectMany(@namespace => @namespace.Structs); }
        }
    }
}
