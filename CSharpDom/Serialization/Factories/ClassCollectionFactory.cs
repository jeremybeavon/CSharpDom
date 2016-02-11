using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassCollectionFactory : AbstractFactory<IClassCollection, ClassCollection>
    {
        public ClassCollectionFactory(IClassCollection field)
            : base(field)
        {
        }

        public override void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new ClassCollection()
            {
                Classes = classCollection.ToList(@class => new ClassFactory(@class).Value),
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new AbstractClassFactory(@class).Value)
            };
        }
    }
}
