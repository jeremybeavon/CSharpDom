namespace CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads
{
    public class ClassWithNestedClassWithIncrementOperatorOverload
    {
        public class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
