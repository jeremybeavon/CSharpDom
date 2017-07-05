namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
