namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithLogicalNotOperatorOverload
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
