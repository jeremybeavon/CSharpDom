namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedInterfaces
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedInterfaceWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public interface Interface<T>
                where T : struct
            {
            }
        }
    }
}
