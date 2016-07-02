namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
