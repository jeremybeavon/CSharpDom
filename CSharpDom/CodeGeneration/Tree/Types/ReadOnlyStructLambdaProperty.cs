using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructLambdaProperty :
        AbstractStructLambdaProperty<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyTypeReference,
            IExpression>
    {
        private readonly StructLambdaProperty property;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly IExpression lambdaExpression;

        public ReadOnlyStructLambdaProperty(StructLambdaProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            lambdaExpression = LinqExpressionBuilder.BuildExpression(property.LambdaExpression);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }
        
        public override StructMemberInheritanceModifier InheritanceModifier
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
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
        }
    }
}
