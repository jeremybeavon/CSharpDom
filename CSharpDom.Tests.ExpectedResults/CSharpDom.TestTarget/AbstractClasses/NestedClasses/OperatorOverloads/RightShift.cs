namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads
{
    public abstract class AbstractClassWithNestedClassWithRightShiftOperatorOverload
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
