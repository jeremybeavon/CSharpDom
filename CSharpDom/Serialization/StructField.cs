using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructField : IStructField<AttributeGroup, IStructType, TypeReference, Field>
    {
        public StructField()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public List<Field> Fields { get; set; }

        public TypeReference FieldType { get; set; }

        public StructFieldModifier Modifier { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<Field> IHasFields<Field>.Fields
        {
            get { return Fields; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructFieldChildren(this, visitor);
        }
    }
}
