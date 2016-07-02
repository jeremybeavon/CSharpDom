namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads
{
    public class ClassWithNestedSealedClassWithOrOperatorOverload
    {
        public sealed class Class
        {
            public static Class operator |(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
