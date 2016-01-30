using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassReferenceFactory : AbstractFactory<IClassReference, ClassReference>
    {
        public ClassReferenceFactory(IClassReference classReference)
            : base(classReference)
        {
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            Value = new ClassReference()
            {
                GenericParameters = classReference.GenericParameters.ToGenericParameterListUsingFactory(),
                Name = classReference.Name
            };
        }
    }
}
