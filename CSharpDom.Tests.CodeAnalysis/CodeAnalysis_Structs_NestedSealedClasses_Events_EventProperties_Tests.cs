using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
