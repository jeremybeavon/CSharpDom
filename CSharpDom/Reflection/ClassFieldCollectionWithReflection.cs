using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassFieldCollectionWithReflection :
        AbstractClassFieldCollection<ClassFieldWithReflection, IClassConstant>
    {
        private readonly AbstractClassFieldCollection fieldCollection;

        internal ClassFieldCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            fieldCollection = new ClassFieldCollection(typeWithReflection);
        }

        internal ClassFieldCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            fieldCollection = new SealedClassFieldCollection(typeWithReflection);
        }

        public override IReadOnlyCollection<IClassConstant> Constants
        {
            get { return fieldCollection.Constants; }
        }

        protected override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get { return fieldCollection; }
        }
    }
}
