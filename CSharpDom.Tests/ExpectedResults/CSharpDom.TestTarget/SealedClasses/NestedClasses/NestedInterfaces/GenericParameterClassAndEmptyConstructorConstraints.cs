namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public interface Interface<T>
                where T : class, new()
            {
            }
        }
    }
}
