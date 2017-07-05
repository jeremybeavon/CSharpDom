namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
