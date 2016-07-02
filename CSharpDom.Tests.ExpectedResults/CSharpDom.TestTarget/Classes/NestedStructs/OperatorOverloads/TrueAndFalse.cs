namespace CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithTrueAndFalseOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator true(Struct parameter1)
            {
                return default(bool);
            }

            public static bool operator false(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
