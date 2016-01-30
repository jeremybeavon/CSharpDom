using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class NestedInterface :
        INestedInterface<
            AttributeGroup,
            IType,
            GenericParameterDeclaration,
            InterfaceReference,
            Event,
            Property,
            Indexer,
            Method>
    {
        public NestedInterface()
        {
            Attributes = new List<AttributeGroup>();
            Events = new List<Event>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Indexers = new List<Indexer>();
            Interfaces = new List<InterfaceReference>();
            Methods = new List<Method>();
            Properties = new List<Property>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public List<Event> Events { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public List<Indexer> Indexers { get; set; }

        public List<InterfaceReference> Interfaces { get; set; }

        public List<Method> Methods { get; set; }

        public string Name { get; set; }
        
        public List<Property> Properties { get; set; }
        
        public MemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<Event> IHasEvents<Event>.Events
        {
            get { return Events; }
        }

        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyCollection<Indexer> IHasIndexers<Indexer>.Indexers
        {
            get { return Indexers; }
        }

        IReadOnlyCollection<InterfaceReference> IHasInterfaces<InterfaceReference>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<Method> IHasMethods<Method>.Methods
        {
            get { return Methods; }
        }

        IReadOnlyCollection<Property> IHasProperties<Property>.Properties
        {
            get { return Properties; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedInterface(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedInterfaceChildren(this, visitor);
        }
    }
}
