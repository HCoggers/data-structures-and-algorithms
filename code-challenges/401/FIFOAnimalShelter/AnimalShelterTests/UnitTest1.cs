using FIFOAnimalShelter;
using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueToEmptyShelter()
        {
            AnimalShelter test = new AnimalShelter();
            test.Enqueue(new Cat());

            Assert.IsType<Cat>(test.Dequeue("cat"));
        }

        [Fact]
        public void CanEnqueueToFullShelter()
        {
            AnimalShelter test = new AnimalShelter();
            test.Enqueue(new Cat());
            test.Enqueue(new Cat());
            test.Enqueue(new Dog());
            test.Dequeue("cat");

            Assert.IsType<Cat>(test.Dequeue("cat"));
        }

        [Fact]
        public void CantDequeueFromEmptyShelter()
        {
            AnimalShelter test = new AnimalShelter();

            Assert.Throws<IndexOutOfRangeException>(() =>test.Dequeue("dog"));
        }

        [Fact]
        public void ReturnsFirstEnqueuedWithoutPreference()
        {
            AnimalShelter test = new AnimalShelter();
            test.Enqueue(new Dog());
            test.Enqueue(new Cat());
            test.Enqueue(new Dog());
            test.Enqueue(new Dog());
            test.Enqueue(new Dog());
            test.Enqueue(new Dog());

            test.Dequeue("no preference");

            Assert.IsType<Cat>(test.Dequeue("No Preference"));
        }
    }
}
