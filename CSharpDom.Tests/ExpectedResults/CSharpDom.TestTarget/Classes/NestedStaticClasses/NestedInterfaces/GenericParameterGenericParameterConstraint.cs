namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces
{
    public class ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
