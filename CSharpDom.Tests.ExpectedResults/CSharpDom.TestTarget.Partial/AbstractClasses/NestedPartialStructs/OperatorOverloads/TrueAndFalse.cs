namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads
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
