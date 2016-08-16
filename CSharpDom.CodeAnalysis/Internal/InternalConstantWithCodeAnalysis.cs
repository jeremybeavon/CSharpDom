using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class InternalConstantWithCodeAnalysis : AbstractConstant<IConstantExpressionWithCodeAnalysis>, IConstantWithCodeAnalysis
    {
        private readonly ConstantGroupWithCodeAnalysis constant;

        public InternalConstantWithCodeAnalysis(ConstantGroupWithCodeAnalysis constant)
        {
            this.constant = constant;
        }

        public override IConstantExpressionWithCodeAnalysis ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public override string Name
        {
            get { return constant.FieldDefinition.Name; }
        }
    }
}
