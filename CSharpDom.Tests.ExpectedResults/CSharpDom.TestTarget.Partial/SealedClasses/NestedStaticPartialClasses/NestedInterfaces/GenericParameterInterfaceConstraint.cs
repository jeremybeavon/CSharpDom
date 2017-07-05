namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
