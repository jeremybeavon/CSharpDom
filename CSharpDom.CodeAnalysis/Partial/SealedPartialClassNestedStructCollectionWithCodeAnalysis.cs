using CSharpDom.BaseClasses.Editable;
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
            SealedClassNestedStructWithCodeAnalysis,
            SealedPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            SealedClassNestedPartialStructWithCodeAnalysis,
            SealedPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal SealedPartialClassNestedStructCollectionWithCodeAnalysis(
            SealedClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<SealedClassNestedStructWithCodeAnalysis, SealedPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new SealedPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<SealedClassNestedPartialStructWithCodeAnalysis, SealedPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new SealedPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
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
