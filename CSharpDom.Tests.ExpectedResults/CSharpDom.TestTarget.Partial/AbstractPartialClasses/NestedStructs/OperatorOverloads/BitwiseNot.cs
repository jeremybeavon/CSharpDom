namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithBitwiseNotOperatorOverload
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
