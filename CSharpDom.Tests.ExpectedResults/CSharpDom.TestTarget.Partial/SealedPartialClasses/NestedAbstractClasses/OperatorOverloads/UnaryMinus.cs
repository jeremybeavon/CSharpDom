namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithUnaryMinusOperatorOverload
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
