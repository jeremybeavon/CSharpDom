using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class BuiltInTypeReferenceFactory : AbstractFactory<IBuiltInTypeReference, BuiltInTypeReference>
    {
        public BuiltInTypeReferenceFactory(IBuiltInTypeReference typeReference)
            : base(typeReference)
        {
        }

        public override void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            Value = new BuiltInTypeReference()
            {
                Type = builtInTypeReference.Type
            };
        }
    }
}
