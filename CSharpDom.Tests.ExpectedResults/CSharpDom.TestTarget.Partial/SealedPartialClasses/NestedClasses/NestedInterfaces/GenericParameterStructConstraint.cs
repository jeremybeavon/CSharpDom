namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterStructConstraint
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
