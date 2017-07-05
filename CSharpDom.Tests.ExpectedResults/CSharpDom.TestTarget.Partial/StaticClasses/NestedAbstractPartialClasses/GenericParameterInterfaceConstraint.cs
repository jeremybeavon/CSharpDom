namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class<T>
            where T : IInterface
        {
        }
    }
}
