using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class SealedClassFieldCollection : AbstractClassFieldCollection
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        public SealedClassFieldCollection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ClassConstantWithReflection> Constants
        {
            get { return typeWithReflection.FieldCollection.Fields.ConstantsWithReflection; }
        }

        protected override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get { return typeWithReflection.FieldCollection.Fields.FieldsWithReflection; }
        }
    }
}
