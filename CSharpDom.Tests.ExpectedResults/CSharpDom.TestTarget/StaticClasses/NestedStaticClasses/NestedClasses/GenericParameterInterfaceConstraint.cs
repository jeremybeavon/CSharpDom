namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
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
