namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : class
            {
            }
        }
    }
}
