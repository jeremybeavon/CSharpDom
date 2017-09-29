using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
