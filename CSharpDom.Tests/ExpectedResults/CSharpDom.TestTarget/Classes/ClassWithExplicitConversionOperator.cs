namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithExplicitConversionOperator
    {
        public static explicit operator ClassWithExplicitConversionOperator(string text)
        {
            return default(ClassWithExplicitConversionOperator);
        }
    }
}
