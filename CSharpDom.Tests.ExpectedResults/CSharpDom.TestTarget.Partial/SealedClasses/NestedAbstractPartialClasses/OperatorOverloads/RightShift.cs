namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithRightShiftOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
