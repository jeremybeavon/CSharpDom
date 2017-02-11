using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
