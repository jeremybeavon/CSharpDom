namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads
{
    public class ClassWithNestedSealedClassWithUnaryMinusOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator -(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
