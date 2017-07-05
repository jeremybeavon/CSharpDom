namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedClassWithUnaryPlusOperatorOverload
    {
        public class Class
        {
            public static Class operator +(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
