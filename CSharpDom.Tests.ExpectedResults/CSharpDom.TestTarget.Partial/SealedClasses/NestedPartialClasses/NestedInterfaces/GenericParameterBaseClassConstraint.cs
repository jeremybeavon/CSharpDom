namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
