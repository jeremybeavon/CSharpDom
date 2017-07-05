namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.OperatorOverloads
{
    public sealed class SealedClassWithNestedStructWithPlusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator +(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
