using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
