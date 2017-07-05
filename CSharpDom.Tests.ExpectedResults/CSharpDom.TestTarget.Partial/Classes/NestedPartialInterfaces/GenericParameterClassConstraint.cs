namespace CSharpDom.TestTarget.Partial.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public interface Interface<T>
            where T : class
        {
        }
    }
}
