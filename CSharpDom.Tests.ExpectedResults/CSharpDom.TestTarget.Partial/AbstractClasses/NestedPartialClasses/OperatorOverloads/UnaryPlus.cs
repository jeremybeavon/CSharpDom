namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedPartialClassWithUnaryPlusOperatorOverload
    {
        public partial class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
