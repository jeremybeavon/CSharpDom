namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
