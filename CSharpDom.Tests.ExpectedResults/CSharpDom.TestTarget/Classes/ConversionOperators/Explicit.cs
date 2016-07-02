namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperator
    {
        public static explicit operator ClassWithExplicitConversionOperator(string text)
        {
            return default(ClassWithExplicitConversionOperator);
        }
    }
}
