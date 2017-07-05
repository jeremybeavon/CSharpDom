namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedStructWithDecrementOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator --(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
