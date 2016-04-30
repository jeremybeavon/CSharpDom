namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedInterfaces
{
    public sealed class SealedClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
