namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithLeftShiftOperatorOverload
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
