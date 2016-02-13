namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator ClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
