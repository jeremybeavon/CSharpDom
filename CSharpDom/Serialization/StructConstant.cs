using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructConstant : IStructConstant<AttributeGroup, IStructType, TypeReference, Constant>
    {
        public StructConstant()
        {
            Attributes = new List<AttributeGroup>();
            Constants = new List<Constant>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<Constant> Constants { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public TypeReference FieldType { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

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
            //visitor.VisitStructConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitStructConstantChildren(this, visitor);
        }
    }
}
