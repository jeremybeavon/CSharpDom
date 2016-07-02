namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators
{
    public struct StructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static explicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
