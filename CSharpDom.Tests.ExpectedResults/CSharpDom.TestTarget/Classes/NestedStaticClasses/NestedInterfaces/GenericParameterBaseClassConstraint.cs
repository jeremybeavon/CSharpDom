namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces
{
    public class ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public interface Interface<T>
                where T : BaseClass
            {
            }
        }
    }
}
