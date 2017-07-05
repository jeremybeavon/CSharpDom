namespace CSharpDom.TestTarget.Partial.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public interface Interface<T>
            where T : class, new()
        {
        }
    }
}
