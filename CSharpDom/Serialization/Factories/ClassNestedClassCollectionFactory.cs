using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedClassCollectionFactory : AbstractFactory<IClassNestedClassCollection, ClassNestedClassCollection>
    {
        public ClassNestedClassCollectionFactory(IClassNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new ClassNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new ClassNestedAbstractClassFactory(@class).Value),
                Classes = classCollection.ToList(@class => new ClassNestedClassFactory(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new ClassNestedSealedClassFactory(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new ClassNestedStaticClassFactory(@class).Value)
            };
        }
    }
}
