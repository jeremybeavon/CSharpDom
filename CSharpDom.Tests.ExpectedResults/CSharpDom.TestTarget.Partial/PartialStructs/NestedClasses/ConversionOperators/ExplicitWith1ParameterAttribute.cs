namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
