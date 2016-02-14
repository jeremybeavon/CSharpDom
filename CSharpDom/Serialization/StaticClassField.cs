using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassField : IStaticClassField<AttributeGroup, IStaticType, TypeReference, Field>
    {
        public StaticClassField()
        {
            Attributes = new List<AttributeGroup>();
            Fields = new List<Field>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public List<Field> Fields { get; set; }

        public TypeReference FieldType { get; set; }

        public StaticClassFieldModifier Modifier { get; set; }

        public StaticClassMemberVisibilityModifier InheritanceModifier { get; set; }

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
            visitor.VisitStaticClassField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitFieldChildren(this, visitor);
        }
    }
}
