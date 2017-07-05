namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
