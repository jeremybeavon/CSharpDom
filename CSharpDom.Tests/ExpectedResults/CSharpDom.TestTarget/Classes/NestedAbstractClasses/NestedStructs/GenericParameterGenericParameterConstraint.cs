namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStructs
{
    public class ClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
