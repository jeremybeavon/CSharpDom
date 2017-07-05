namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
