namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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
