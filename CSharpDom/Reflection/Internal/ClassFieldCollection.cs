using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassFieldCollection : AbstractClassFieldCollection
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        public ClassFieldCollection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ClassConstantWithReflection> Constants
        {
            get { return new ClassConstantWithReflection[0]; }
        }

        protected override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get { return typeWithReflection.FieldCollection.Fields; }
        }
    }
}
