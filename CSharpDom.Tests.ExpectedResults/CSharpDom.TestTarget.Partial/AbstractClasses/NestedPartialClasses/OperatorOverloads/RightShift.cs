namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedPartialClassWithRightShiftOperatorOverload
    {
        public partial class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
