namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
