namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedInterfaces
{
    public static class StaticClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
