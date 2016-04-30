namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedClassWithNestedInterfaceWithGenericParameterClassConstraint
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
