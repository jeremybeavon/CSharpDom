using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InternalFieldWithMonoCecil : AbstractField<ExpressionNotSupported>, IFieldWithMonoCecil
    {
        private readonly FieldInfo field;

        public InternalFieldWithMonoCecil(FieldInfo field)
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
