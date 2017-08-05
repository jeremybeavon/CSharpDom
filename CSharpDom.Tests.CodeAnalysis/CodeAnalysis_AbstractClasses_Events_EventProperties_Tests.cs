using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }
    }
}
