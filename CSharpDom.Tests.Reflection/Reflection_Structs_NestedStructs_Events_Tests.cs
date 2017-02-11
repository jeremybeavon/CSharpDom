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
            TestStruct(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
