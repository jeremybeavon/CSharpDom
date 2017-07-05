namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedStructWithBitwiseNotOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ~(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
