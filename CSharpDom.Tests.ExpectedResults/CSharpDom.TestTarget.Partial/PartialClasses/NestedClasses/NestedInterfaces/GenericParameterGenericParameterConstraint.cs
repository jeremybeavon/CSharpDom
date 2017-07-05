namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedInterfaces
{
    public partial class PartialClassWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
