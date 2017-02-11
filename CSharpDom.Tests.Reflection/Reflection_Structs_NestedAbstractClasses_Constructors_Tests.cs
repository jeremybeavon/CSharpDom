using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
