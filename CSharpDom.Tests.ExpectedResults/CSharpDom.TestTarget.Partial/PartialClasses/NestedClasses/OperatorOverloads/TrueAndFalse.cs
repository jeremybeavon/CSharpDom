namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedClassWithTrueAndFalseOperatorOverloads
    {
        public class Class
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
