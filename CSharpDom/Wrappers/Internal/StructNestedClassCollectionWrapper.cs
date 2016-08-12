using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedClassCollectionWrapper : AbstractWrapper<IStructNestedClassCollection>
    {
        public StructNestedClassCollectionWrapper(IStructNestedClassCollection collection)
            : base(collection)
        {
        }

        public override void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new StructNestedClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new StructNestedAbstractClassWrapper(@class).Value),
                Classes = classCollection.ToList(@class => new StructNestedClassWrapper(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new StructNestedSealedClassWrapper(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new StructNestedStaticClassWrapper(@class).Value)
            };
        }
    }
}
