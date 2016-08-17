﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IList<TParameter> Parameters { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyList<TParameter> IHasParameters<TParameter>.Parameters
        {
            get { return new ReadOnlyCollection<TParameter>(Parameters); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstructor(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorChildren(this, visitor);
        }
    }
}