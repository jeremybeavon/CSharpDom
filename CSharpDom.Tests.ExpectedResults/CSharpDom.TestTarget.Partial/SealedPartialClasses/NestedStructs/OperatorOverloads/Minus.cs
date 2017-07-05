namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedStructWithMinusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator -(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
