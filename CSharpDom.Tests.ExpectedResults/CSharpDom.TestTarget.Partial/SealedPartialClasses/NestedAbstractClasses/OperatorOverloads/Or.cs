namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithOrOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator |(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
