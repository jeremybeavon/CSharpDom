namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
