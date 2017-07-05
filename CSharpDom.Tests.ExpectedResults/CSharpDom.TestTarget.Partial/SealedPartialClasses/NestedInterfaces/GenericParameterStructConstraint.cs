namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
