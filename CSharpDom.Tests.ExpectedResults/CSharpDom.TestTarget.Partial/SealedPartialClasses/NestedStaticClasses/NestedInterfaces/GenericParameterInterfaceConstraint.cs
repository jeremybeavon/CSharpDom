namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
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
