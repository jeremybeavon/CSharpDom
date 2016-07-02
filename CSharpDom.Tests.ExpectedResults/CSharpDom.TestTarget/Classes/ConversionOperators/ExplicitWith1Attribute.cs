namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator ClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
