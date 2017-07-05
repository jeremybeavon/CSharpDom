namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithExclusiveOrOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator ^(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
