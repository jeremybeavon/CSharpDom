namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.OperatorOverloads
{
    public class ClassWithNestedPartialClassWithTrueAndFalseOperatorOverloads
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
