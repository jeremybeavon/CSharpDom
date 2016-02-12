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
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassFieldCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<IClassConstant> Constants
        {
            get { return new IClassConstant[0]; }
        }

        protected override IReadOnlyCollection<ClassFieldWithReflection> Fields
        {
            get { return typeWithReflection.Fields.Fields; }
        }
    }
}
