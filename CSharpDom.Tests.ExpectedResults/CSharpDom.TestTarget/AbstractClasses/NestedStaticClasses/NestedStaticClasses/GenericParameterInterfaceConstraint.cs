namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
