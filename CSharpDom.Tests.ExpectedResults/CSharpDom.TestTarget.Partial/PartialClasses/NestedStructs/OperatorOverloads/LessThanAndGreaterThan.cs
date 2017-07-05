namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads
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
