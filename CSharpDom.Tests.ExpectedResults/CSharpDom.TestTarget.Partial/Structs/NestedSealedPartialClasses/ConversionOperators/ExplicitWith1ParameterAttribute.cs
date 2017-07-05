namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.ConversionOperators
{
    public struct StructWithNestedSealedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed partial class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
