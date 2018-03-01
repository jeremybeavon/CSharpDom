using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassLambdaProperty :
        ISealedClassLambdaProperty<
            AttributeGroup,
            ISealedType,
            TypeReference,
            Expression>
    {
        public SealedClassLambdaProperty()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public ISealedType DeclaringType
        {
            get { return null; }
        }

        public SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }

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
            visitor.VisitSealedClassLambdaProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
