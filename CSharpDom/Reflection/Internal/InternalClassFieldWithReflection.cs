using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class InternalClassFieldWithReflection : AbstractField<ExpressionNotSupported>, IFieldWithReflection
    {
        private readonly ClassFieldWithReflection field;

        public InternalClassFieldWithReflection(ClassFieldWithReflection field)
        {
            this.field = field;
        }

        public override ExpressionNotSupported InitialValue
        {
            get { return field.InitialValue; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
