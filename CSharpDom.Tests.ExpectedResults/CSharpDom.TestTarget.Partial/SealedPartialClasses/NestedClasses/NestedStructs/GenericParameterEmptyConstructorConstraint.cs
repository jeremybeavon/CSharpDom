namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
