using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassConstant : IClassConstant<AttributeGroup, IClassType, TypeReference, Constant>
    {
        public ClassConstant()
        {
            Attributes = new List<AttributeGroup>();
            Constants = new List<Constant>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<Constant> Constants { get; set; }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public TypeReference FieldType { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<Constant> IHasConstants<Constant>.Constants
        {
            get { return Constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassConstantChildren(this, visitor);
        }
    }
}
