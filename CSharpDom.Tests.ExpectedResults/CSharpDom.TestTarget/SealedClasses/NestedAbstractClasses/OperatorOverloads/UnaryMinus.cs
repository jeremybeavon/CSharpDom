namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
