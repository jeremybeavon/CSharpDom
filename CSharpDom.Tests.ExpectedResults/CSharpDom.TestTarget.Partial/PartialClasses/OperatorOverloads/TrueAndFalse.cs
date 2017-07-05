namespace CSharpDom.TestTarget.Partial.PartialClasses.OperatorOverloads
{
    public partial class PartialClassWithTrueAndFalseOperatorOverloads
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
