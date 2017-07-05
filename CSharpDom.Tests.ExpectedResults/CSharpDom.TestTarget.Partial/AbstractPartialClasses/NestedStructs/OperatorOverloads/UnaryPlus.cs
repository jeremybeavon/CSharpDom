namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithUnaryPlusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator +(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
