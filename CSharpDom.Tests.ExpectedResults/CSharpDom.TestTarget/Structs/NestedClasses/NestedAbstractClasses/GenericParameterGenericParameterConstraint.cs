namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses
{
    public struct StructWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
