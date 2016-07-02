namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractClassWithModuloOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator %(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
