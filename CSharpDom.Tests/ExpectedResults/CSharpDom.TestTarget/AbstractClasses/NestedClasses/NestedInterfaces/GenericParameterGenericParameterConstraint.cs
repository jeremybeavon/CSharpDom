namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
