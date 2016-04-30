namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : IInterface
            {
            }
        }
    }
}
