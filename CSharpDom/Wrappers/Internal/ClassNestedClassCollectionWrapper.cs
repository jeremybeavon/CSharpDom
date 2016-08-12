using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedClassCollectionWrapper : AbstractWrapper<IClassNestedClassCollection>
    {
        public ClassNestedClassCollectionWrapper(IClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new ClassNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new ClassNestedAbstractClassWrapper(@class).Value),
                Classes = classCollection.ToList(@class => new ClassNestedClassWrapper(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new ClassNestedSealedClassWrapper(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new ClassNestedStaticClassWrapper(@class).Value)
            };
        }
    }
}
