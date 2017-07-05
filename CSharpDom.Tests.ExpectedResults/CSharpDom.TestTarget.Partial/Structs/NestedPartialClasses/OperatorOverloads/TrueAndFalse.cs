namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedPartialClassWithTrueAndFalseOperatorOverloads
    {
        public partial class Class
        {
            public static bool operator true(Class parameter1)
            {
                return default(bool);
            }

            public static bool operator false(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
