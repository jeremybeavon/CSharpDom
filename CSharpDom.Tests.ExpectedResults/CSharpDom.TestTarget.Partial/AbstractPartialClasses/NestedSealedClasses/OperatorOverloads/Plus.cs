namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.OperatorOverloads
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithPlusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
