namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
