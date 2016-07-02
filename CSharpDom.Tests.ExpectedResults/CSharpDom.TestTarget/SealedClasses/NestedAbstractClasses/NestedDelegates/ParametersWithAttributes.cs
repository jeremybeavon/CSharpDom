namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
