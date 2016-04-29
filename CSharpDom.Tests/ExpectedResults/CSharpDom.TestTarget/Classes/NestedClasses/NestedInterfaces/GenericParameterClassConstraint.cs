namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces
{
    public class ClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
