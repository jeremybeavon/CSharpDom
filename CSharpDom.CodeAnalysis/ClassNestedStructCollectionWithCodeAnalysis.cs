using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<ClassNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly ClassTypeWithCodeAnalysis classType;

        internal ClassNestedStructCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
        }

        public override ICollection<PartialStructNotSupported> PartialStructs
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<ClassNestedStructWithCodeAnalysis> Structs
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
