namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators
{
    public struct StructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public sealed class Class
        {
            public static implicit operator Class([Attribute1]string text)
            {
                return default(Class);
            }
        }
    }
}
