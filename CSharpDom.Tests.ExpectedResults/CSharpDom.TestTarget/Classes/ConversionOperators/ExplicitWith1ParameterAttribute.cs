namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator ClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
