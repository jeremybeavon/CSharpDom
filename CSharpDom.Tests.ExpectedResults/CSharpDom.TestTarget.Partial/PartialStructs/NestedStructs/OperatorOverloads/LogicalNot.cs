namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedStructWithLogicalNotOperatorOverload
    {
        public struct Struct
        {
            public static bool operator !(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
