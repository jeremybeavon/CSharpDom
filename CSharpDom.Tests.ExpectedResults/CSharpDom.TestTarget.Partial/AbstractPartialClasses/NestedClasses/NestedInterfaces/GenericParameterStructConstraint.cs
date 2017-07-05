namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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
