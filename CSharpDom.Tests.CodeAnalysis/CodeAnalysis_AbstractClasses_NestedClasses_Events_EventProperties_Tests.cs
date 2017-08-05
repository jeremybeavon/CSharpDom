using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
