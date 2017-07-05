namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
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
