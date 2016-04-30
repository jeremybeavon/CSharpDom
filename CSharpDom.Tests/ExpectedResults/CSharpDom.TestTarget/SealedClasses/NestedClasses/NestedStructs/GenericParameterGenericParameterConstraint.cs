namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
