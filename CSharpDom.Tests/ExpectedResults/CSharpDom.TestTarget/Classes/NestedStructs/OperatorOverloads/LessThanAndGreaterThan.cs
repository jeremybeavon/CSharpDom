namespace CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads
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
