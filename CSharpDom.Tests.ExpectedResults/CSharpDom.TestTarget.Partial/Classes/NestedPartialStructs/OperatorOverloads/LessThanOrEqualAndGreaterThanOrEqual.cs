namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads
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
