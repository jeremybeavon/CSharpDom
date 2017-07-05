namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
