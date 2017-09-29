using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
