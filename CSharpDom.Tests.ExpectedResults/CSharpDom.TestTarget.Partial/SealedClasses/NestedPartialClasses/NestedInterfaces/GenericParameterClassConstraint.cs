namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
