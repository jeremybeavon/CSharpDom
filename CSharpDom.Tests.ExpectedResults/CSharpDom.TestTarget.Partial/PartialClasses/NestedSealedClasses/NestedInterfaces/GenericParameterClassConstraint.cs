namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassConstraint
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
