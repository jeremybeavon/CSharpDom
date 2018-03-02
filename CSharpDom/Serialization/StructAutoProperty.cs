using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class StructAutoProperty :
        IStructAutoProperty<
            AttributeGroup,
            IStructType,
            TypeReference,
            StructAutoPropertyAccessor,
            Expression>
    {
        public StructAutoProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public StructAutoPropertyAccessor GetAccessor { get; set; }

        public StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public StructAutoPropertyAccessor SetAccessor { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public Expression InitialValue { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructAutoProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
