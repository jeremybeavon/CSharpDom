namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
