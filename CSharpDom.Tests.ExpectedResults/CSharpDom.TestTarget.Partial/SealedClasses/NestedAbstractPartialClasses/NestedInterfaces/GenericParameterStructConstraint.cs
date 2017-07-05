namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
