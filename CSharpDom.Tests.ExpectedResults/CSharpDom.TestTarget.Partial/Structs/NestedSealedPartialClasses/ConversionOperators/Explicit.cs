namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.ConversionOperators
{
    public struct StructWithNestedSealedPartialClassWithExplicitConversionOperator
    {
        public sealed partial class Class
        {
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
