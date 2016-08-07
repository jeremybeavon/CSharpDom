using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Reflection.ConstantExpressions;
using System;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InternalConstantWithReflection : AbstractConstant<IConstantExpressionWithReflection>, IConstantWithReflection
    {
        private readonly ConstantGroupWithReflection constant;

        public InternalConstantWithReflection(ConstantGroupWithReflection constant)
        {
            this.constant = constant;
        }

        public override IConstantExpressionWithReflection ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public override string Name
        {
            get { return constant.Name; }
        }
    }
}
