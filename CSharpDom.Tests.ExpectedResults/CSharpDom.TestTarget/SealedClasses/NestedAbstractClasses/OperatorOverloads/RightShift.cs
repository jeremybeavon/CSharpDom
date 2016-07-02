namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractClassWithRightShiftOperatorOverload
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
