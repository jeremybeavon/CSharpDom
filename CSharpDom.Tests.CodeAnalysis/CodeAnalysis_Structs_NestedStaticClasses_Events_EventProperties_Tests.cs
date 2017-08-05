using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
