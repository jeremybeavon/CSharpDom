namespace CSharpDom.TestTarget.SealedClasses.Properties
{
    public sealed class SealedClassWithNewStaticProperty : BaseClassWithProperty
    {
        public new static string Property { get; set; }
    }
}
