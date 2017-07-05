namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.OperatorOverloads
{
    public sealed class SealedClassWithNestedStructWithLeftShiftOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator <<(Struct parameter1, int parameter2)
            {
                return default(Struct);
            }
        }
    }
}
