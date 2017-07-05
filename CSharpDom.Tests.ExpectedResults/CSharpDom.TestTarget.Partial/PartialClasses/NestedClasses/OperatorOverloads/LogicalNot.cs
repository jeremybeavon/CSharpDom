namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedClassWithLogicalNotOperatorOverload
    {
        public class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
