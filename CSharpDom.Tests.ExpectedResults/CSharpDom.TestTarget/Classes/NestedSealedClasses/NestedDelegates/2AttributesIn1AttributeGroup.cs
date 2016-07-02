namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
