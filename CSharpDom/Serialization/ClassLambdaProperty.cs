using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class ClassLambdaProperty :
        IClassLambdaProperty<
            AttributeGroup,
            IClassType,
            TypeReference,
            Expression>
    {
        public ClassLambdaProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public string Name { get; set; }

        public TypeReference PropertyType { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public Expression LambdaExpression { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassLambdaProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
