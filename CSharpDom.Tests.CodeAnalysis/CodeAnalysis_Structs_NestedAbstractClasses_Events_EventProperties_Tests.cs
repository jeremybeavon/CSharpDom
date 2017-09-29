using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
