namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
