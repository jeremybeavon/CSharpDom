namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperator
    {
        public static implicit operator ClassWithImplicitConversionOperator(string text)
        {
            return default(ClassWithImplicitConversionOperator);
        }
    }
}
