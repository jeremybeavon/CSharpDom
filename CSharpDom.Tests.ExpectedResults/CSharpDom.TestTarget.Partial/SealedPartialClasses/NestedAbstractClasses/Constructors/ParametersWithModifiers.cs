namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
