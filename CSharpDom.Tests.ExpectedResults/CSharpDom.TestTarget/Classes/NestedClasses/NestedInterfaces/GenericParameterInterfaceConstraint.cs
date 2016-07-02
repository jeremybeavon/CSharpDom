namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces
{
    public class ClassWithNestedClassWithNestedInterfaceWithGenericParameterInterfaceConstraint
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
