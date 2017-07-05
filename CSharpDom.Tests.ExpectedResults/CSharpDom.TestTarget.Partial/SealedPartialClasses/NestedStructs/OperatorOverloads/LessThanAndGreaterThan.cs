namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator <(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }
        }
    }
}
