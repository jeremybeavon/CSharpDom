namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.OperatorOverloads
{
    public struct StructWithNestedSealedPartialClassWithTrueAndFalseOperatorOverloads
    {
        public sealed partial class Class
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
