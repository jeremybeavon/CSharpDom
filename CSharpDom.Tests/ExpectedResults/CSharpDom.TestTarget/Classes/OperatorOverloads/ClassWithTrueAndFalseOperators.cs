namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithTrueAndFalseOperators
    {
        public static bool operator true(ClassWithTrueAndFalseOperators parameter1)
        {
            return default(bool);
        }

        public static bool operator false(ClassWithTrueAndFalseOperators parameter1)
        {
            return default(bool);
        }
    }
}
