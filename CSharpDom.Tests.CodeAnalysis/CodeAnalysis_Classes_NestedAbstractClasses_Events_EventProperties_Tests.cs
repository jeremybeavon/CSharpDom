using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
