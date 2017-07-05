namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator <=(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }

            public static bool operator >=(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }
        }
    }
}
