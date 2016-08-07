using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassFieldCollectionWithMonoCecil :
        AbstractClassFieldCollection<ClassFieldWithMonoCecil, ClassConstantWithMonoCecil>
    {
        private readonly AbstractClassFieldCollection fieldCollection;

        internal ClassFieldCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            fieldCollection = new ClassFieldCollection(typeWithMonoCecil);
        }

        internal ClassFieldCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            fieldCollection = new SealedClassFieldCollection(typeWithMonoCecil);
        }

        public override IReadOnlyCollection<ClassConstantWithMonoCecil> Constants
        {
            get { return fieldCollection.Constants; }
        }

        protected override IReadOnlyCollection<ClassFieldWithMonoCecil> Fields
        {
            get { return fieldCollection; }
        }
    }
}
