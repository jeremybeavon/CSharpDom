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
            TestClassAsync(typeof(ClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalNestedStructUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedStructUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedStructUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedStructUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPublicNestedStructUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicNestedStruct));
        }
    }
}
