using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<
            PartialClassNestedStructWithCodeAnalysis,
            PartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedStructWithCodeAnalysis,
            PartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            ClassNestedPartialStructWithCodeAnalysis,
            PartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal PartialClassNestedStructCollectionWithCodeAnalysis(
            ClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<ClassNestedStructWithCodeAnalysis, PartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new PartialClassNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<ClassNestedPartialStructWithCodeAnalysis, PartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new PartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<PartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<PartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
