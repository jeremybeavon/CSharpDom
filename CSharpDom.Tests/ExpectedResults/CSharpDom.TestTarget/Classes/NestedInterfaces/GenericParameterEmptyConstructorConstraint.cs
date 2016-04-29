namespace CSharpDom.TestTarget.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public interface Interface<T>
            where T : new()
        {
        }
    }
}
