namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
