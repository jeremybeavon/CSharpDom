using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
