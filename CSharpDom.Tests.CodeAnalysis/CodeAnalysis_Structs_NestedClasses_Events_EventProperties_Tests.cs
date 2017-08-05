using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
