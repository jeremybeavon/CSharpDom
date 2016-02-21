using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructNestedClassCollection :
        IStructNestedClassCollection<
            StructNestedClass,
            StructNestedAbstractClass,
            StructNestedSealedClass,
            StructNestedStaticClass,
            IPartialClassCollection>
    {
        public StructNestedClassCollection()
        {
            AbstractClasses = new List<StructNestedAbstractClass>();
            Classes = new List<StructNestedClass>();
            SealedClasses = new List<StructNestedSealedClass>();
            StaticClasses = new List<StructNestedStaticClass>();
        }

        public List<StructNestedAbstractClass> AbstractClasses { get; set; }

        public List<StructNestedClass> Classes { get; set; }

        public int Count
        {
            get { return Classes.Count + AbstractClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public IPartialClassCollection PartialClasses
        {
            get { return null; }
        }

        public List<StructNestedSealedClass> SealedClasses { get; set; }

        public List<StructNestedStaticClass> StaticClasses { get; set; }

        IReadOnlyCollection<StructNestedAbstractClass> IHasAbstractClasses<StructNestedAbstractClass>.AbstractClasses
        {
            get { return AbstractClasses; }
        }

        IReadOnlyCollection<StructNestedSealedClass> IHasSealedClasses<StructNestedSealedClass>.SealedClasses
        {
            get { return SealedClasses; }
        }

        IReadOnlyCollection<StructNestedStaticClass> IHasStaticClasses<StructNestedStaticClass>.StaticClasses
        {
            get { return StaticClasses; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedClassCollectionChildren(this, visitor);
        }

        public IEnumerator<StructNestedClass> GetEnumerator()
        {
            return Classes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
