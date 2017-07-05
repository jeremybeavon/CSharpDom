namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMinusOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator -(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
