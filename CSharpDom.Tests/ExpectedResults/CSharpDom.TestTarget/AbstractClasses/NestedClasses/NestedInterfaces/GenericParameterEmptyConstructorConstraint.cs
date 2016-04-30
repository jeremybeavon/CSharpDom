namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
