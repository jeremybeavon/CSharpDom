namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.OperatorOverloads
{
    public sealed class SealedClassWithNestedStructWithUnaryPlusOperatorOverload
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
