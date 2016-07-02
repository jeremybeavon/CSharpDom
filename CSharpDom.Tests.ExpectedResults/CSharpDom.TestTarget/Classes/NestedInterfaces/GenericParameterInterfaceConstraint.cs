namespace CSharpDom.TestTarget.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
