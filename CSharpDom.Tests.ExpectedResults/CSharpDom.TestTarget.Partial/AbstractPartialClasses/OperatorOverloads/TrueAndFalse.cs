namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithTrueAndFalseOperatorOverloads
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
