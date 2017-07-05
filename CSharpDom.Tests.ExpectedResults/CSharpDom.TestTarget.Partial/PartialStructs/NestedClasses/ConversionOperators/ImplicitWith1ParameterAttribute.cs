namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
