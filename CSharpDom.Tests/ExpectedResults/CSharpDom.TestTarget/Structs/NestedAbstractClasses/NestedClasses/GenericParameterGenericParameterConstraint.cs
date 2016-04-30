namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses
{
    public struct StructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
