namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedPartialClassWithLogicalNotOperatorOverload
    {
        public partial class Class
        {
            public static bool operator !(Class parameter1)
            {
                return default(bool);
            }
        }
    }
}
