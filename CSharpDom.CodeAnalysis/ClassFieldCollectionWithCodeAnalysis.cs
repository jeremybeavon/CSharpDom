using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassFieldCollectionWithCodeAnalysis :
        AbstractClassFieldCollection<ClassFieldWithCodeAnalysis, ClassConstantWithCodeAnalysis>
    {
        private readonly AbstractClassFieldCollection fieldCollection;

        internal ClassFieldCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            fieldCollection = new ClassFieldCollection(typeWithCodeAnalysis);
        }

        internal ClassFieldCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            fieldCollection = new SealedClassFieldCollection(typeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<ClassConstantWithCodeAnalysis> Constants
        {
            get { return fieldCollection.Constants; }
        }

        protected override IReadOnlyCollection<ClassFieldWithCodeAnalysis> Fields
        {
            get { return fieldCollection; }
        }
    }
}
