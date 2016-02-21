using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassConstant : IStaticClassConstant<AttributeGroup, IStaticType, TypeReference, Constant>
    {
        public StaticClassConstant()
        {
            Attributes = new List<AttributeGroup>();
            Constants = new List<Constant>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<Constant> Constants { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public TypeReference FieldType { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitStaticClassConstant(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassConstantChildren(this, visitor);
        }
    }
}
