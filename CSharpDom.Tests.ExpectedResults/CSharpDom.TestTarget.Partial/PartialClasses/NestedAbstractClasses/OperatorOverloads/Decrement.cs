namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.OperatorOverloads
{
    public partial class PartialClassWithNestedAbstractClassWithDecrementOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
