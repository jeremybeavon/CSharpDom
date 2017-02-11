using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Structs_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicConstructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
