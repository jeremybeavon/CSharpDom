using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedClassCollectionFactory : AbstractFactory<IStructNestedClassCollection, StructNestedClassCollection>
    {
        public StructNestedClassCollectionFactory(IStructNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new StructNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new StructNestedAbstractClassFactory(@class).Value),
                Classes = classCollection.ToList(@class => new StructNestedClassFactory(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new StructNestedSealedClassFactory(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new StructNestedStaticClassFactory(@class).Value)
            };
        }
    }
}
