using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
