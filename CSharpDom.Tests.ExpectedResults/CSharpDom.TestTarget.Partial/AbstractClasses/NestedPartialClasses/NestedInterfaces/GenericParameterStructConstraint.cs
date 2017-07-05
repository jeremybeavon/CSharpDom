namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
