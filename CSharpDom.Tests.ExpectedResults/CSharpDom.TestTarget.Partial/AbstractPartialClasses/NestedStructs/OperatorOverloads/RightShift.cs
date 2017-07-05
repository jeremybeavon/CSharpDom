namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithRightShiftOperatorOverload
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
