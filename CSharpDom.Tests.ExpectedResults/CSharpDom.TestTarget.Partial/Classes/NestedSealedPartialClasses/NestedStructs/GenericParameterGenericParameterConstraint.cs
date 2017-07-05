namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
