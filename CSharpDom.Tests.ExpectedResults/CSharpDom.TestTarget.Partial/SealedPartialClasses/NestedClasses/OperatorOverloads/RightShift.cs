namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.OperatorOverloads
{
    public sealed partial class SealedPartialClassWithNestedClassWithRightShiftOperatorOverload
    {
        public class Class
        {
            public static Class operator >>(Class parameter1, int parameter2)
            {
                return default(Class);
            }
        }
    }
}
