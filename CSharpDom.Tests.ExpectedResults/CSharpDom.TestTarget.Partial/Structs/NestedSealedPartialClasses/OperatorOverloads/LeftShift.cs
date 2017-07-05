namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedSealedPartialClassWithLeftShiftOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator <<(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
