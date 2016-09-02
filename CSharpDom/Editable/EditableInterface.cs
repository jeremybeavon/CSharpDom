using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableInterface<TNamespace,
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
        public virtual TDocument Document { get; set; }
        
        public virtual bool IsPartial { get; set; }
        
        public virtual TNamespace Namespace { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TypeVisibilityModifier Visibility { get; set; }
        
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
