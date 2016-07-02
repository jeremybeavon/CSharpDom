namespace CSharpDom.TestTarget.Classes.ConversionOperators
{
    public class ClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator ClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
