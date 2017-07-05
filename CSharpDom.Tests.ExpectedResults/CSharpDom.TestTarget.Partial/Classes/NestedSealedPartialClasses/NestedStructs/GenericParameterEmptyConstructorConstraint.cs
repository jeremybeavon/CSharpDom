namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedStructs
{
    public class ClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
