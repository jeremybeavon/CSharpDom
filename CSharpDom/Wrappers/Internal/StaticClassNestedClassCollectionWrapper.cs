using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedClassCollectionWrapper : AbstractWrapper<IStaticClassNestedClassCollection>
    {
        public StaticClassNestedClassCollectionWrapper(IStaticClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new StaticClassNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new StaticClassNestedAbstractClassWrapper(@class).Value),
                Classes = classCollection.ToList(@class => new StaticClassNestedClassWrapper(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new StaticClassNestedSealedClassWrapper(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new StaticClassNestedStaticClassWrapper(@class).Value)
            };
        }
    }
}
