namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator ClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
