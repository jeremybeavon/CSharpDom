using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> :
        IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IList<TGenericParameter> GenericParameters { get; set; }
        
        public virtual string Name { get; set; }

        public virtual IList<TParameter> Parameters { get; set; }

        public virtual ICollection<TAttributeGroup> ReturnAttributes { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TGenericParameter> IHasGenericParameters<TGenericParameter>.GenericParameters
        {
            get { return new ReadOnlyCollection<TGenericParameter>(GenericParameters); }
        }

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        IReadOnlyCollection<TAttributeGroup> IHasReturnAttributes<TAttributeGroup>.ReturnAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(ReturnAttributes); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethod(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}
