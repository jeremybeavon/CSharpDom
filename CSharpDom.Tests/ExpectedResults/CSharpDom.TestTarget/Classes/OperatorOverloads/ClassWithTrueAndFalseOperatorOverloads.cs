namespace CSharpDom.TestTarget.Classes.OperatorOverloads
{
    public class ClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(ClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(ClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
