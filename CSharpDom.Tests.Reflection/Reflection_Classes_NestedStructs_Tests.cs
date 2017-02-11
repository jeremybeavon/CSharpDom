using CSharpDom.TestTarget.Classes.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalNestedStructUsingReflection()
        {
            TestClass(typeof(ClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedStructUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedStructUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedStructUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPublicNestedStructUsingReflection()
        {
            TestClass(typeof(ClassWithPublicNestedStruct));
        }
    }
}
