using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
