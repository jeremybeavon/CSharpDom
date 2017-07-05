namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWithParametersWithAttributes
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
