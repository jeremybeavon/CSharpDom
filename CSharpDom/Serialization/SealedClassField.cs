using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassField : ISealedClassField<AttributeGroup, ISealedType, TypeReference, Field>
    {
        public SealedClassField()
        {
            Attributes = new List<AttributeGroup>();
            Fields = new List<Field>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public List<Field> Fields { get; set; }

        public TypeReference FieldType { get; set; }

        public ClassFieldModifier Modifier { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

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
            visitor.VisitSealedClassField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitFieldChildren(this, visitor);
        }
    }
}
