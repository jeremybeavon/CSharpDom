using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
