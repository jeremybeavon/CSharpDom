namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithPlusOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator +(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
