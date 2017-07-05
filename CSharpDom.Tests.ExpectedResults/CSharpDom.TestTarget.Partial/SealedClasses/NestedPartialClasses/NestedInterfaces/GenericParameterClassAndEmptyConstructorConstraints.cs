namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
