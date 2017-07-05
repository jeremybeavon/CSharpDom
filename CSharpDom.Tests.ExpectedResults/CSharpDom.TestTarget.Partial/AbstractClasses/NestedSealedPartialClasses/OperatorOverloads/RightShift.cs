namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithRightShiftOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
