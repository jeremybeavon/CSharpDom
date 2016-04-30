namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
