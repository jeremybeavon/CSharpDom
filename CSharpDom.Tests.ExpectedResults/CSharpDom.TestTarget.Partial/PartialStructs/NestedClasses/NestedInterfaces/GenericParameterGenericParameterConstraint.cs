namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedInterfaces
{
    public partial struct PartialStructWithWithNestedClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
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
