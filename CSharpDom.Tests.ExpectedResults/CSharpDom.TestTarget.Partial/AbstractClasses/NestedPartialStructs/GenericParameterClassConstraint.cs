namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
