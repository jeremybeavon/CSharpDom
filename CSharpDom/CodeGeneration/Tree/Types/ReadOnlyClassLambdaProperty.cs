using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassLambdaProperty :
        AbstractClassLambdaProperty<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyTypeReference,
            IExpression>
    {
        private readonly ClassLambdaProperty property;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly IExpression lambdaExpression;

        public ReadOnlyClassLambdaProperty(ClassLambdaProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            lambdaExpression = LinqExpressionBuilder.BuildExpression(property.LambdaExpression);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IClassType DeclaringType
        {
            get { return null; }
        }
        
        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
        }

        public override IExpression LambdaExpression => lambdaExpression;

        public override string Name
        {
            get { return property.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }
        
        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
        }
    }
}
