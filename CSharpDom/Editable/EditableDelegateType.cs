using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> :
        IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }
        
        public abstract IList<TGenericParameter> GenericParameters { get; set; }

        public abstract string Name { get; set; }

        public abstract IList<TParameter> Parameters { get; set; }

        public abstract TTypeReference ReturnType { get; set; }

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

         public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateType(this);
        }

         public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateTypeChildren(this, visitor);
        }
    }
}
