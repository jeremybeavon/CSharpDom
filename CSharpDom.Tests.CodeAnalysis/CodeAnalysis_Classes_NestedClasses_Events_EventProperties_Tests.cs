using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
