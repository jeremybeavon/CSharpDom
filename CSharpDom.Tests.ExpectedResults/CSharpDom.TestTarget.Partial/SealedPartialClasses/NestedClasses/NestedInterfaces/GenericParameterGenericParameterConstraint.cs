namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedInterfaces
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
