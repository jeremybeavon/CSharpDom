using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterface<TNamespace,
        TDocument,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEvent,
        TProperty,
        TIndexer,
        TMethod> :
        EditableInterfaceType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>,
        IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEvent : IInterfaceEvent
        where TProperty : IInterfaceProperty
        where TIndexer : IInterfaceIndexer
        where TMethod : IInterfaceMethod
    {
        public abstract TDocument Document { get; set; }
        
        public abstract TNamespace Namespace { get; set; }

        public abstract TProject Project { get; set; }

        public abstract TSolution Solution { get; set; }

        public abstract TypeVisibilityModifier Visibility { get; set; }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterface(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceChildren(this, visitor);
        }
    }
}
