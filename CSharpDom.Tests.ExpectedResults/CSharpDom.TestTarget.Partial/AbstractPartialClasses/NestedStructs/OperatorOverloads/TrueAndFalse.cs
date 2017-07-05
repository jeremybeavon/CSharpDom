namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedStructWithTrueAndFalseOperatorOverloads
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
