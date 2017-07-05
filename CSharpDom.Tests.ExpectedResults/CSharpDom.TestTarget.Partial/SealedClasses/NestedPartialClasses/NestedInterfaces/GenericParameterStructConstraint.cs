namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
