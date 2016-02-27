using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    public sealed class TypeofExpressionWithMonoCecil :
        AbstractTypeofExpression<ITypeReferenceWithMonoCecil>, 
        IConstantExpressionWithMonoCecil
    {
        private readonly ITypeReferenceWithMonoCecil type;

        internal TypeofExpressionWithMonoCecil(ITypeReferenceWithMonoCecil type)
        {
            this.type = type;
        }

        public override ITypeReferenceWithMonoCecil Type
        {
            get { return type; }
        }
    }
}
