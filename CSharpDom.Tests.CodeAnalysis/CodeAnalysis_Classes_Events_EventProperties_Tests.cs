using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
