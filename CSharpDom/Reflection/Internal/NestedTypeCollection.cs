using System;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedTypeCollection<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>
    {
        private readonly Lazy<NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>> nestedTypes;

        public NestedTypeCollection(Func<NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>> nestedTypes)
        {
            this.nestedTypes = new Lazy<NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>>(nestedTypes);
        }

        public NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> NestedTypes
        {
            get { return nestedTypes.Value; }
        }
    }
}
