namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedInterfaces
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
