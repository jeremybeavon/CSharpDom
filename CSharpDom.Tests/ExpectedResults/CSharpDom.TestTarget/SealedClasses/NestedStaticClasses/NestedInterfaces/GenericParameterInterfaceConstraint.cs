namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
