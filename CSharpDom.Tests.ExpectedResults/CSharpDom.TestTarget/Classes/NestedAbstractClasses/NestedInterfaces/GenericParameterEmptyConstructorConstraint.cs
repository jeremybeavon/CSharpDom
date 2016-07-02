namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : new()
            {
            }
        }
    }
}
