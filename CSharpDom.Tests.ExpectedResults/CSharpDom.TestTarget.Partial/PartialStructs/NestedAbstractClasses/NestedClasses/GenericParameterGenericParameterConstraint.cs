namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
