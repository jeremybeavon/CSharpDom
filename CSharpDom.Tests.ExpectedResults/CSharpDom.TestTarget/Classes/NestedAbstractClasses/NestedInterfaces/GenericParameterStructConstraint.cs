namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
