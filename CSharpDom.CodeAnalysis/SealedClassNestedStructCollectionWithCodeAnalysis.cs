using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<
            SealedClassNestedStructWithCodeAnalysis,
            SealedClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly WrappedCollection<
            ClassNestedStructWithCodeAnalysis,
            SealedClassNestedStructWithCodeAnalysis> structs;
        private readonly WrappedCollection<
            ClassNestedPartialStructWithCodeAnalysis,
            SealedClassNestedPartialStructWithCodeAnalysis> partialStructs;

        internal SealedClassNestedStructCollectionWithCodeAnalysis(
            ClassNestedStructCollectionWithCodeAnalysis structCollection)
        {
            structs = new WrappedCollection<ClassNestedStructWithCodeAnalysis, SealedClassNestedStructWithCodeAnalysis>(
                structCollection.Structs,
                parent => new SealedClassNestedStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.Structs = value);
            partialStructs = new WrappedCollection<ClassNestedPartialStructWithCodeAnalysis, SealedClassNestedPartialStructWithCodeAnalysis>(
                structCollection.PartialStructs,
                parent => new SealedClassNestedPartialStructWithCodeAnalysis(parent),
                child => child.Struct,
                value => structCollection.PartialStructs = value);
        }

        public override ICollection<SealedClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { partialStructs.Replace(value); }
        }

        public override ICollection<SealedClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { structs.Replace(value); }
        }
    }
}
