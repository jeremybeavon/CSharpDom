using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
