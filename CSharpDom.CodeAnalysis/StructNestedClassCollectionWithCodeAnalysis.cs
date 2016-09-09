using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedClassCollectionWithCodeAnalysis :
        EditableStructNestedClassCollection<
            StructNestedClassWithCodeAnalysis,
            StructNestedAbstractClassWithCodeAnalysis,
            StructNestedSealedClassWithCodeAnalysis,
            StructNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis structType;

        internal StructNestedClassCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
        }

        public override ICollection<StructNestedAbstractClassWithCodeAnalysis> AbstractClasses
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

        public override ICollection<StructNestedClassWithCodeAnalysis> Classes
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

        public override PartialClassCollectionNotSupported PartialClasses
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

        public override ICollection<StructNestedSealedClassWithCodeAnalysis> SealedClasses
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

        public override ICollection<StructNestedStaticClassWithCodeAnalysis> StaticClasses
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
