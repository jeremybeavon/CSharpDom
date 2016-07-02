namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator ClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
