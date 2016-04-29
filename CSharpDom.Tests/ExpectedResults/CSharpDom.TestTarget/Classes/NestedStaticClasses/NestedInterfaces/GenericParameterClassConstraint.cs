namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces
{
    public class ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
