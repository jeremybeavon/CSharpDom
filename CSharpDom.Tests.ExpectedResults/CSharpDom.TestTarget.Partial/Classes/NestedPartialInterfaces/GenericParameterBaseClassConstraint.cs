namespace CSharpDom.TestTarget.Partial.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public interface Interface<T>
            where T : BaseClass
        {
        }
    }
}
