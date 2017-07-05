namespace CSharpDom.TestTarget.Partial.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public interface Interface<T>
            where T : IInterface
        {
        }
    }
}
