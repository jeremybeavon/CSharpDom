namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
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
