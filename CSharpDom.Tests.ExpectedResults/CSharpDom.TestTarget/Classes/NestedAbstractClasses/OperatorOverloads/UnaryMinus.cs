namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads
{
    public class ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload
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
