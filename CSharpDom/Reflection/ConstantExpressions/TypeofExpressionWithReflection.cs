using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Reflection.ConstantExpressions
{
    public sealed class TypeofExpressionWithReflection :
        AbstractTypeofExpression<ITypeReferenceWithReflection>, 
        IConstantExpressionWithReflection
    {
        private readonly ITypeReferenceWithReflection type;

        internal TypeofExpressionWithReflection(ITypeReferenceWithReflection type)
        {
            this.type = type;
        }

        public override ITypeReferenceWithReflection Type
        {
            get { return type; }
        }
    }
}
