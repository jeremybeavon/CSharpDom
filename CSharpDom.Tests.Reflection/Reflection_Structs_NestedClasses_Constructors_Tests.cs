using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Structs_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
