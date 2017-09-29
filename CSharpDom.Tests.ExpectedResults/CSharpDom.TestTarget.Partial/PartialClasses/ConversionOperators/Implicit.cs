namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperator
    {
        public static implicit operator PartialClassWithImplicitConversionOperator(string text)
        {
            return default(PartialClassWithImplicitConversionOperator);
        }
    }
}
