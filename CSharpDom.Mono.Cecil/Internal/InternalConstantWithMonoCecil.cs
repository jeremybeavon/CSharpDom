using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InternalConstantWithMonoCecil : AbstractConstant<IConstantExpressionWithMonoCecil>, IConstantWithMonoCecil
    {
        private readonly ConstantGroupWithMonoCecil constant;

        public InternalConstantWithMonoCecil(ConstantGroupWithMonoCecil constant)
        {
            this.constant = constant;
        }

        public override IConstantExpressionWithMonoCecil ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public override string Name
        {
            get { return constant.FieldDefinition.Name; }
        }
    }
}
