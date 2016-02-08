namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperator
    {
        public static implicit operator ClassWithImplicitConversionOperator(string text)
        {
            return default(ClassWithImplicitConversionOperator);
        }
    }
}
