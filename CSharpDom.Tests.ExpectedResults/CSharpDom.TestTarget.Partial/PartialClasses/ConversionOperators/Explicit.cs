namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperator
    {
        public static explicit operator PartialClassWithExplicitConversionOperator(string text)
        {
            return default(PartialClassWithExplicitConversionOperator);
        }
    }
}
