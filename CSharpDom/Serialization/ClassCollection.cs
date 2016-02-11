using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class ClassCollection :
        IClassCollection<Class, AbstractClass, SealedClass, StaticClass, PartialClassCollectionNotSupported>
    {
        public ClassCollection()
        {
            Classes = new List<Class>();
            AbstractClasses = new List<AbstractClass>();
            SealedClasses = new List<SealedClass>();
            StaticClasses = new List<StaticClass>();
        }

        public List<Class> Classes { get; set; }

        public List<AbstractClass> AbstractClasses { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public PartialClassCollectionNotSupported PartialClasses
        {
            get { return null; }
        }

        public List<SealedClass> SealedClasses { get; set; }

        public List<StaticClass> StaticClasses { get; set; }

        IReadOnlyCollection<AbstractClass> IHasAbstractClasses<AbstractClass>.AbstractClasses
        {
            get { return AbstractClasses; }
        }

        IReadOnlyCollection<SealedClass> IHasSealedClasses<SealedClass>.SealedClasses
        {
            get { return SealedClasses; }
        }

        IReadOnlyCollection<StaticClass> IHasStaticClasses<StaticClass>.StaticClasses
        {
            get { return StaticClasses; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassCollectionChildren(this, visitor);
        }

        public IEnumerator<Class> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
