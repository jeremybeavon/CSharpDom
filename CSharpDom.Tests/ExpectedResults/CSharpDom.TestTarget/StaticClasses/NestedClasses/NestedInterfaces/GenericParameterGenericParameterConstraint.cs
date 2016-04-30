namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
