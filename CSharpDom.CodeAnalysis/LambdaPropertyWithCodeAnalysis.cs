using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LambdaPropertyWithCodeAnalysis :
        EditableLambdaProperty<
            AttributeGroupWithCodeAnalysis,
            IEditableBasicType,
            ITypeReferenceWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly CachedExpressionNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> lambdaExpression;

        internal LambdaPropertyWithCodeAnalysis()
        {
            property = new PropertyWithCodeAnalysis();
            lambdaExpression = new CachedExpressionNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                property.Node,
                syntax => syntax.ExpressionBody?.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpressionBody(childSyntax == null ? null : SyntaxFactory.ArrowExpressionClause(childSyntax)));
        }
        
        public PropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IEditableBasicType DeclaringType
        {
            get { return property.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override IExpressionWithCodeAnalysis LambdaExpression
        {
            get { return lambdaExpression.Value; }
            set { lambdaExpression.Value = value; }
        }

        public override string Name
        {
            get { return property.Name; }
            set { property.Name = value; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
            set { property.PropertyType = value; }
        }
        
        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }
    }
}
