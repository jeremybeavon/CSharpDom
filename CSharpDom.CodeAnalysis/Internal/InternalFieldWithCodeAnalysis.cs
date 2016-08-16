using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class InternalFieldWithCodeAnalysis : AbstractField<ExpressionNotSupported>, IFieldWithCodeAnalysis
    {
        private readonly FieldDefinition field;

        public InternalFieldWithCodeAnalysis(FieldDefinition field)
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
