namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint
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
