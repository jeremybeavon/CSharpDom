namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
