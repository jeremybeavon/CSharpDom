namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators
{
    public struct StructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
