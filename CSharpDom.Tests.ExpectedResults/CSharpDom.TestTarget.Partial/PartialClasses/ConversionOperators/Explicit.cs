namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperator
    {
        public static explicit operator ClassWithExplicitConversionOperator(string text)
        {
            return default(ClassWithExplicitConversionOperator);
        }
    }
}
