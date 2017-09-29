namespace CSharpDom.TestTarget.Partial.PartialClasses.OperatorOverloads
{
    public partial class PartialClassWithTrueAndFalseOperatorOverloads
    {
        public static bool operator true(PartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }

        public static bool operator false(PartialClassWithTrueAndFalseOperatorOverloads parameter1)
        {
            return default(bool);
        }
    }
}
