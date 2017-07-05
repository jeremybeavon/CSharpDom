namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithLeftShiftOperatorOverload
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
