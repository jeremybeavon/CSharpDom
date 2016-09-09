using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedStructCollectionWithCodeAnalysis :
        EditableStructNestedStructCollection<StructNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis structType;

        internal StructNestedStructCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
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

        public override ICollection<StructNestedStructWithCodeAnalysis> Structs
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
