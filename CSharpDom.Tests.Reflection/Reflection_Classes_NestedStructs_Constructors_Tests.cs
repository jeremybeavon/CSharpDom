using CSharpDom.TestTarget.Classes.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedStructs_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }
        
        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicConstructor));
        }
    }
}
