namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithBitwiseNotOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
