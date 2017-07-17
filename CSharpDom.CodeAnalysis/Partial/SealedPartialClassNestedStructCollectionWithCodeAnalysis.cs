using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<
            SealedPartialClassNestedStructWithCodeAnalysis,
            SealedPartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedStructWithCodeAnalysis,
            SealedPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            ClassNestedPartialStructWithCodeAnalysis,
            SealedPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal SealedPartialClassNestedStructCollectionWithCodeAnalysis(
            ClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<ClassNestedStructWithCodeAnalysis, SealedPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new SealedPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<ClassNestedPartialStructWithCodeAnalysis, SealedPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new SealedPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<SealedPartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<SealedPartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
