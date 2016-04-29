namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedInterfaces
{
    public class ClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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
