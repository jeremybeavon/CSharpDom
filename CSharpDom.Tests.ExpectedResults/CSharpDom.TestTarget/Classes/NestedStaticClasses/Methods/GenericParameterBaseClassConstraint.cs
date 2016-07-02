namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
