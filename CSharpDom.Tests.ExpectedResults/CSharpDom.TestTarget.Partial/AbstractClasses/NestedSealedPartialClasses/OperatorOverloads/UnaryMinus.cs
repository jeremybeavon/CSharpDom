namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithUnaryMinusOperatorOverload
    {
        public sealed partial class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
