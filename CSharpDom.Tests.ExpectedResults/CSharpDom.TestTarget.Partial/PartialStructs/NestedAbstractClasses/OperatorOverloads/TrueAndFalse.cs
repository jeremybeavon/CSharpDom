namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedAbstractClassWithTrueAndFalseOperatorOverloads
    {
        public abstract class Class
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
