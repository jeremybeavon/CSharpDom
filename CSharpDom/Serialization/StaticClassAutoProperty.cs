using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassAutoProperty :
        IStaticClassAutoProperty<
            AttributeGroup,
            IStaticType,
            TypeReference,
            StaticClassAccessor,
            Expression>
    {
        public StaticClassAutoProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public StaticClassAccessor GetAccessor { get; set; }
        
        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public StaticClassAccessor SetAccessor { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }

        public Expression InitialValue { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAutoProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
