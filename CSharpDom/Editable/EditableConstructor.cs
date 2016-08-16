using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TMethodBody Body { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IReadOnlyList<TParameter> Parameters { get; set; }

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
