namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads
{
    public sealed class SealedClassWithNestedClassWithRightShiftOperatorOverload
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
