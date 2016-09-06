using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableDelegate<
        TNamespace,
        TDocument,
        TProject,
        TSolution,
        TAttributeGroup,
        TGenericParameter,
        TTypeReference,
        TParameter> :
        EditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>,
        IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public virtual TDocument Document { get; set; }
        
        public virtual TNamespace Namespace { get; set; }
        
        public virtual TProject Project { get; set; }
        
        public virtual TSolution Solution { get; set; }

        public virtual TypeVisibilityModifier Visibility { get; set; }
        
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegate(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateChildren(this, visitor);
        }
    }
}
