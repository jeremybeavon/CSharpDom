namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedAbstractClassWithRightShiftOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
