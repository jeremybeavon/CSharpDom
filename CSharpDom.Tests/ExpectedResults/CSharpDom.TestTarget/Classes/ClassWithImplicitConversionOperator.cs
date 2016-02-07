namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithImplicitConversionOperator
    {
        public static implicit operator ClassWithImplicitConversionOperator(string text)
        {
            return default(ClassWithImplicitConversionOperator);
        }
    }
}
