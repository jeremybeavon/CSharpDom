namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
