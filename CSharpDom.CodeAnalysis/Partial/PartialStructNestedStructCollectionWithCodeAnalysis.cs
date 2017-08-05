using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedStructCollectionWithCodeAnalysis :
        EditableStructNestedStructCollection<
            PartialStructNestedStructWithCodeAnalysis,
            PartialStructNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            StructNestedStructWithCodeAnalysis,
            PartialStructNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            StructNestedPartialStructWithCodeAnalysis,
            PartialStructNestedPartialStructWithCodeAnalysis> partialStructs;

        internal PartialStructNestedStructCollectionWithCodeAnalysis(
            StructNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<StructNestedStructWithCodeAnalysis, PartialStructNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new PartialStructNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<StructNestedPartialStructWithCodeAnalysis, PartialStructNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new PartialStructNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<PartialStructNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<PartialStructNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
