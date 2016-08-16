using System;
using System.Collections.Generic;
using CSharpDom.Common;

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
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDocument Document { get; set; }

        public virtual IReadOnlyList<TGenericParameter> GenericParameters { get; set; }

        public virtual string Name { get; set; }

        public virtual TNamespace Namespace { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

        public virtual TProject Project { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        public virtual TSolution Solution { get; set; }

        public virtual TypeVisibilityModifier Visibility { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegate(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateChildren(this, visitor);
        }
    }
}
