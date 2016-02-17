using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InternalFieldWithReflection : AbstractField<ExpressionNotSupported>, IFieldWithReflection
    {
        private readonly FieldInfo field;

        public InternalFieldWithReflection(FieldInfo field)
        {
            this.field = field;
        }

        public override ExpressionNotSupported InitialValue
        {
            get { return new ExpressionNotSupported(); }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
