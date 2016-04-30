namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
