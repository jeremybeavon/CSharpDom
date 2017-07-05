namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
