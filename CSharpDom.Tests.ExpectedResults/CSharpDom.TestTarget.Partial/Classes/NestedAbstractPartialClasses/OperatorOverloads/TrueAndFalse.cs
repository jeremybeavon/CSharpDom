namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractPartialClassWithTrueAndFalseOperatorOverloads
    {
        public abstract partial class Class
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
