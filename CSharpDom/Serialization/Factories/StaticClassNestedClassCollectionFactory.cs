using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedClassCollectionFactory : AbstractFactory<IStaticClassNestedClassCollection, StaticClassNestedClassCollection>
    {
        public StaticClassNestedClassCollectionFactory(IStaticClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new StaticClassNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new StaticClassNestedAbstractClassFactory(@class).Value),
                Classes = classCollection.ToList(@class => new StaticClassNestedClassFactory(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new StaticClassNestedSealedClassFactory(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new StaticClassNestedStaticClassFactory(@class).Value)
            };
        }
    }
}
