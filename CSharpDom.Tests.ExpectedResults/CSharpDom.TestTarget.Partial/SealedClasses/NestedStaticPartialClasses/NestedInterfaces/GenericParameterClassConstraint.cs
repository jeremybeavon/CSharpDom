namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
