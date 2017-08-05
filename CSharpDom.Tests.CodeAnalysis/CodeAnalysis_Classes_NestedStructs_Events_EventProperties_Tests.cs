using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
