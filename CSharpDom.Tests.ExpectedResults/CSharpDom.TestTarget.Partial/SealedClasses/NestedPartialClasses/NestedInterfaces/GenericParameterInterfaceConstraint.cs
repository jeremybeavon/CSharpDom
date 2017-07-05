namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
