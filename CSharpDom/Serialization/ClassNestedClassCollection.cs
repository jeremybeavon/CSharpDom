using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class ClassNestedClassCollection :
        IClassNestedClassCollection<
            ClassNestedClass,
            IClassNestedAbstractClass,
            IClassNestedSealedClass,
            IClassNestedStaticClass,
            IPartialClassCollection>
    {
        public ClassNestedClassCollection()
        {
            Classes = new List<ClassNestedClass>();
        }

        public IReadOnlyCollection<IClassNestedAbstractClass> AbstractClasses
        {
            get { return new IClassNestedAbstractClass[0]; }
        }

        public List<ClassNestedClass> Classes { get; set; }

        public int Count
        {
            get { return AbstractClasses.Count + Classes.Count + PartialClasses.Count + SealedClasses.Count + StaticClasses.Count; }
        }

        public IPartialClassCollection PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public IReadOnlyCollection<IClassNestedSealedClass> SealedClasses
        {
            get { return new IClassNestedSealedClass[0]; }
        }

        public IReadOnlyCollection<IClassNestedStaticClass> StaticClasses
        {
            get { return new IClassNestedStaticClass[0]; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedClassCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
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
