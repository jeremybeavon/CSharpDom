namespace CSharpDom.TestTarget.AbstractClasses.OperatorOverloads
{
    public abstract class AbstractClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(AbstractClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(AbstractClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
