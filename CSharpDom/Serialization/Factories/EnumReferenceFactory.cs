using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class EnumReferenceFactory : AbstractFactory<IEnumReference, EnumReference>
    {
        public EnumReferenceFactory(IEnumReference enumReference)
            : base(enumReference)
        {
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            Value = new EnumReference()
            {
                Name = enumReference.Name
            };
        }
    }
}
