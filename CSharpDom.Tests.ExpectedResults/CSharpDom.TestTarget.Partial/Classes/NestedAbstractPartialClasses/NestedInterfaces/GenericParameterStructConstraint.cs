namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedInterfaces
{
    public class ClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
