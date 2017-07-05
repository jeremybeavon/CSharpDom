using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedClassCollection :
        IClassNestedClassCollection<
            ClassNestedClass,
            ClassNestedAbstractClass,
            ClassNestedSealedClass,
            ClassNestedStaticClass,
            IPartialClassCollection>
    {
        public ClassNestedClassCollection()
        {
            Classes = new List<ClassNestedClass>();
            AbstractClasses = new List<ClassNestedAbstractClass>();
            SealedClasses = new List<ClassNestedSealedClass>();
            StaticClasses = new List<ClassNestedStaticClass>();
        }

        public List<ClassNestedAbstractClass> AbstractClasses { get; set; }

        public List<ClassNestedClass> Classes { get; set; }

        public int Count
        {
            get { return AbstractClasses.Count + Classes.Count + PartialClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public IPartialClassCollection PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public List<ClassNestedSealedClass> SealedClasses { get; set; }

        public List<ClassNestedStaticClass> StaticClasses { get; set; }

        IReadOnlyCollection<ClassNestedAbstractClass> IHasAbstractClasses<ClassNestedAbstractClass>.AbstractClasses
        {
            get { return AbstractClasses; }
        }

        IReadOnlyCollection<ClassNestedSealedClass> IHasSealedClasses<ClassNestedSealedClass>.SealedClasses
        {
            get { return SealedClasses; }
        }

        IReadOnlyCollection<ClassNestedStaticClass> IHasStaticClasses<ClassNestedStaticClass>.StaticClasses
        {
            get { return StaticClasses; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedClassCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassNestedClass> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
