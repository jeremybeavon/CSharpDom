using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported.Partial;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<StaticClassNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis type;

        internal StaticClassNestedStructCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
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

        public override ICollection<StaticClassNestedStructWithCodeAnalysis> Structs
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
