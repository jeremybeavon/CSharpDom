namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithUnaryPlusOperatorOverload
    {
        public abstract partial class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
