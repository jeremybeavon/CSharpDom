namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithBitwiseNotOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator ~(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
