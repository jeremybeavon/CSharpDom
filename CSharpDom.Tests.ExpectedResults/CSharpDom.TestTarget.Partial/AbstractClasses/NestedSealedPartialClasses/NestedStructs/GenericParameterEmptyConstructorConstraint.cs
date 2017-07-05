namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
