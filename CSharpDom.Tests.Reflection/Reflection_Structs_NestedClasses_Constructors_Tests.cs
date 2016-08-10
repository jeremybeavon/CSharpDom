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
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
