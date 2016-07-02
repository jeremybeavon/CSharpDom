namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
