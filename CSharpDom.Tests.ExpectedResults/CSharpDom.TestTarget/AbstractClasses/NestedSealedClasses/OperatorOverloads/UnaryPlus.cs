namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
