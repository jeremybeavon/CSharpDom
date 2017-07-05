namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
