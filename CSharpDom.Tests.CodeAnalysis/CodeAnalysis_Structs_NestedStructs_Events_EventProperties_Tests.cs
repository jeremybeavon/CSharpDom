using CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
