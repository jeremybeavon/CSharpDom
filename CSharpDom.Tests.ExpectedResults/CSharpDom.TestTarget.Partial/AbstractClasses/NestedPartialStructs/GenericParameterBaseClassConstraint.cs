namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
