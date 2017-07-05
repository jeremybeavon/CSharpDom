namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedClassWithDecrementOperatorOverload
    {
        public class Class
        {
            public static Class operator --(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
