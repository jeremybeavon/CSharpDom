using System;
using System.Reflection;
using CSharpDom.Common;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InternalFieldWithReflection : AbstractField<IConstantExpressionWithReflection>, IFieldWithReflection
    {
        private readonly FieldInfo field;

        public InternalFieldWithReflection(FieldInfo field)
        {
            this.field = field;
        }

        public override IConstantExpressionWithReflection InitialValue
        {
            get { return null; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
