namespace CSharpDom.TestTarget.Classes.NestedInterfaces
{
    public class ClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public interface Interface<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
