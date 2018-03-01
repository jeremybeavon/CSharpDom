using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassLambdaProperty :
        IStaticClassLambdaProperty<
            AttributeGroup,
            IStaticType,
            TypeReference,
            Expression>
    {
        public StaticClassLambdaProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }

        public Expression LambdaExpression { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassLambdaProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
