namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedClassWithMultiplyOperatorOverload
    {
        public class Class
        {
            public static Class operator *(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
