namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedSealedPartialClassWithDecrementOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
