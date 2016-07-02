namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
