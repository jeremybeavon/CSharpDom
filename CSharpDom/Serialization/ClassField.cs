using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ClassField : IClassField<AttributeGroup, IClassType, TypeReference>
    {
        public ClassField()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public TypeReference FieldType { get; set; }

        public ClassFieldModifier Modifier { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            //GenericVisitor.VisitFieldChildren(this, visitor);
        }
    }
}
