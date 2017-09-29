namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(AbstractPartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(AbstractPartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
