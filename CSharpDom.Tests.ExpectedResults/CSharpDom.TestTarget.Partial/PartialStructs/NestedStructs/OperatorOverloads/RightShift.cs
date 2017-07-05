namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedStructWithRightShiftOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator >>(Struct parameter1, int parameter2)
            {
                return default(Struct);
            }
        }
    }
}
