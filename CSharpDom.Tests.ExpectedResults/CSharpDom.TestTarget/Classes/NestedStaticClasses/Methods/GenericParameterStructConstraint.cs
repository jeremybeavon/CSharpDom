namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
