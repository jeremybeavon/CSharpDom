namespace CSharpDom.TestTarget.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public interface Interface<T>
            where T : struct
        {
        }
    }
}
