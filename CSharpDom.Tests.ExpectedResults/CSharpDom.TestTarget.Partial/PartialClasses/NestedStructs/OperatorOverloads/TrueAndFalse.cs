namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.OperatorOverloads
{
    public partial class PartialClassWithNestedStructWithTrueAndFalseOperatorOverloads
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
