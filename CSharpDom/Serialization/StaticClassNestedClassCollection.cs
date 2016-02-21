using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StaticClassNestedClassCollection :
        IStaticClassNestedClassCollection<
            StaticClassNestedClass,
            StaticClassNestedAbstractClass,
            StaticClassNestedSealedClass,
            StaticClassNestedStaticClass,
            IPartialClassCollection>
    {
        public StaticClassNestedClassCollection()
        {
            AbstractClasses = new List<StaticClassNestedAbstractClass>();
            Classes = new List<StaticClassNestedClass>();
            SealedClasses = new List<StaticClassNestedSealedClass>();
            StaticClasses = new List<StaticClassNestedStaticClass>();
        }

        public List<StaticClassNestedAbstractClass> AbstractClasses { get; set; }

        public List<StaticClassNestedClass> Classes { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public IPartialClassCollection PartialClasses
        {
            get { return null; }
        }

        public List<StaticClassNestedSealedClass> SealedClasses { get; set; }

        public List<StaticClassNestedStaticClass> StaticClasses { get; set; }

        IReadOnlyCollection<StaticClassNestedAbstractClass> IHasAbstractClasses<StaticClassNestedAbstractClass>.AbstractClasses
        {
            get { return AbstractClasses; }
        }

        IReadOnlyCollection<StaticClassNestedSealedClass> IHasSealedClasses<StaticClassNestedSealedClass>.SealedClasses
        {
            get { return SealedClasses; }
        }

        IReadOnlyCollection<StaticClassNestedStaticClass> IHasStaticClasses<StaticClassNestedStaticClass>.StaticClasses
        {
            get { return StaticClasses; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
            //GenericVisitor.visitstatic
        }

        public IEnumerator<StaticClassNestedClass> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
