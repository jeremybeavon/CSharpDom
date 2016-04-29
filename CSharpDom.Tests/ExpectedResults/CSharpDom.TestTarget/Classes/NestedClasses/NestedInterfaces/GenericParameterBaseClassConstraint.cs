namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces
{
    public class ClassWithNestedClassWithNestedInterfaceWithGenericParameterBaseClassConstraint
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
