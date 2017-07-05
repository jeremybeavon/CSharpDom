namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
