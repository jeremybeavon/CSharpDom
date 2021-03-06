﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedClassCollectionWithReflection :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithReflection,
            ClassNestedAbstractClassWithReflection,
            ClassNestedSealedClassWithReflection,
            ClassNestedStaticClassWithReflection,
            PartialClassCollectionNotSupported>
    {
        private readonly AbstractClassNestedClassCollection classCollection;

        internal ClassNestedClassCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            classCollection = new ClassNestedClassCollection(typeWithReflection);
        }

        internal ClassNestedClassCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            classCollection = new SealedClassNestedClassCollection(typeWithReflection);
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithReflection> AbstractClasses
        {
            get { return classCollection.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return classCollection.PartialClasses; }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithReflection> SealedClasses
        {
            get { return classCollection.SealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithReflection> StaticClasses
        {
            get { return classCollection.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
        {
            get { return classCollection; }
        }
    }
}
