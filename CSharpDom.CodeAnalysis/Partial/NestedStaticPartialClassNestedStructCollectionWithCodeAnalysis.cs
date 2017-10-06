using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis :
        EditableStaticClassNestedStructCollection<
            NestedStaticPartialClassNestedStructWithCodeAnalysis,
            NestedStaticPartialClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            NestedStaticClassNestedStructWithCodeAnalysis,
            NestedStaticPartialClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            NestedStaticClassNestedPartialStructWithCodeAnalysis,
            NestedStaticPartialClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis(
            NestedStaticClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<NestedStaticClassNestedStructWithCodeAnalysis, NestedStaticPartialClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new NestedStaticPartialClassNestedStructWithCodeAnalysis(parent),
                child => child.InternalStruct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<NestedStaticClassNestedPartialStructWithCodeAnalysis, NestedStaticPartialClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new NestedStaticPartialClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<NestedStaticPartialClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<NestedStaticPartialClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
