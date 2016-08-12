using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassCollectionWrapper : AbstractWrapper<IClassCollection>
    {
        public ClassCollectionWrapper(IClassCollection field)
            : base(field)
        {
        }

        public override void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            Value = new ClassCollection()
            {
                AbstractClasses = classCollection.AbstractClasses.ToList(@class => new AbstractClassWrapper(@class).Value),
                Classes = classCollection.ToList(@class => new ClassWrapper(@class).Value),
                SealedClasses = classCollection.SealedClasses.ToList(@class => new SealedClassWrapper(@class).Value),
                StaticClasses = classCollection.StaticClasses.ToList(@class => new StaticClassWrapper(@class).Value)
            };
        }
    }
}
