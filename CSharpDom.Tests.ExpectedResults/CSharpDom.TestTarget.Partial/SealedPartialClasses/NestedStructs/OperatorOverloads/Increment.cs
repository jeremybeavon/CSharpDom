namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedStructWithIncrementOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ++(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
