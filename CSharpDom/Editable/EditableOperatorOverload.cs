﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> :
        IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IOperatorParameter
        where TMethodBody : IMethodBody
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual OperatorOverloadType OperatorType { get; set; }

        public virtual IList<TParameter> Parameters { get; set; }

        public virtual TTypeReference ReturnType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitOperatorOverload(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitOperatorOverloadChildren(this, visitor);
        }
    }
}