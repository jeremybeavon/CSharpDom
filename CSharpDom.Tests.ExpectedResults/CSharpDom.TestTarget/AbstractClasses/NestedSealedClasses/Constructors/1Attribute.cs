namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedClassWithConstructorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public Class()
            {
            }
        }
    }
}
