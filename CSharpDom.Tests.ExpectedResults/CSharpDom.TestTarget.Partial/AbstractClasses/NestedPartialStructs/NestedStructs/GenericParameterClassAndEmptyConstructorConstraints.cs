namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
