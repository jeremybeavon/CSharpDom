namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
