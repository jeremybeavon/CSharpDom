using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InternalFieldWithMonoCecil : AbstractField<ExpressionNotSupported>, IFieldWithMonoCecil
    {
        private readonly FieldDefinition field;

        public InternalFieldWithMonoCecil(FieldDefinition field)
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
