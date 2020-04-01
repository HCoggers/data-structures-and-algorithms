using FIFOAnimalShelter.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        public Cat CatFront { get; set; }
        public Cat CatRear { get; set; }

        public Dog DogFront { get; set; }
        public Dog DogRear { get; set; }

        private int NextId = 1;

        /// <summary>
        /// Adds a new animal to the end of the line waiting for a home
        /// </summary>
        /// <param name="animal">the cat or dog to be added</param>
        public void Enqueue(Animal animal)
        {
            animal.Id = NextId;
            if (NextId == Int32.MaxValue)
                throw new IndexOutOfRangeException("The Shelter Can't Handle Any More Animals!");
            NextId++;
            if (animal.GetType().Equals(typeof(Cat)))
            {
                if (CatFront == null)
                    CatFront = (Cat)animal;
                else
                    CatRear.Next = (Cat)animal;
                CatRear = (Cat)animal;
            }
            else
            {
                if (DogFront == null)
                    DogFront = (Dog)animal;
                else
                    DogRear.Next = (Dog)animal;
                DogRear = (Dog)animal;
            }

        }

        /// <summary>
        /// Removes the first animal that matches the argument of "dog" or "cat"
        /// </summary>
        /// <param name="pref">preference of animal type.</param>
        /// <returns>the animal to be "adopted"</returns>
        public Animal Dequeue(string pref)
        {
            try
            {
                Animal result;
                if (pref == "cat" || (pref != "dog" && CatFront.Id < DogFront.Id))
                {
                    result = CatFront;
                    CatFront = (Cat)result.Next;
                }
                else
                {
                    result = DogFront;
                    DogFront = (Dog)result.Next;
                }

                return result;
            }
            catch
            {
                throw new IndexOutOfRangeException("The Shelter is EMPTY!");
            }
            
        }
    }
}
