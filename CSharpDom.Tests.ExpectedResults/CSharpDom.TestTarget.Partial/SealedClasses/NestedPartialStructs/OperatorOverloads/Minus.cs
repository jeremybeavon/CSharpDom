namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.OperatorOverloads
{
    public sealed class SealedClassWithNestedStructWithMinusOperatorOverload
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
