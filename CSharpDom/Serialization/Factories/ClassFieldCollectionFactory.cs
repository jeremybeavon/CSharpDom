using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassFieldCollectionFactory :
        AbstractFactory<IClassFieldCollection, ClassFieldCollection>
    {
        public ClassFieldCollectionFactory(IClassFieldCollection fieldCollection)
            : base(fieldCollection)
        {
        }

        public override void VisitClassFieldCollection<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection)
        {
            Value = new ClassFieldCollection()
            {
                Fields = fieldCollection.ToList(@field => new ClassFieldFactory(@field).Value),
                Constants = fieldCollection.Constants.ToList(constant => new ClassConstantFactory(constant).Value)
            };
        }
    }
}
