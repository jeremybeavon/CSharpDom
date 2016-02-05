using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class Interface :
        IInterface<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            InterfaceReference,
            InterfaceEvent,
            InterfaceProperty,
            InterfaceIndexer,
            InterfaceMethod>
    {
        public Interface()
        {
            Attributes = new List<AttributeGroup>();
            Events = new List<InterfaceEvent>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Indexers = new List<InterfaceIndexer>();
            Interfaces = new List<InterfaceReference>();
            Methods = new List<InterfaceMethod>();
            Properties = new List<InterfaceProperty>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<InterfaceEvent> Events { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<InterfaceIndexer> Indexers { get; set; }

        public List<InterfaceReference> Interfaces { get; set; }

        public bool IsPartial { get; set; }

        public List<InterfaceMethod> Methods { get; set; }

        public string Name { get; set; }

        public NamespaceNotSupported Namespace
        {
            get { return null; }
        }

        public ProjectNotSupported Project
        {
            get { return null; }
        }

        public List<InterfaceProperty> Properties { get; set; }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public TypeVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<InterfaceEvent> IHasEvents<InterfaceEvent>.Events
        {
            get { return Events; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyCollection<InterfaceIndexer> IHasIndexers<InterfaceIndexer>.Indexers
        {
            get { return Indexers; }
        }

        IReadOnlyCollection<InterfaceReference> IHasInterfaces<InterfaceReference>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<InterfaceMethod> IHasMethods<InterfaceMethod>.Methods
        {
            get { return Methods; }
        }

        IReadOnlyCollection<InterfaceProperty> IHasProperties<InterfaceProperty>.Properties
        {
            get { return Properties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterface(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceChildren(this, visitor);
        }
    }
}
