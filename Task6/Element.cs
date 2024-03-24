namespace Task6
{
    public class ElementSet
    {
        public class NonExistentElementException : Exception { };
        private List<Element> elements;
        private int evenCount;
        //initiate set
        public ElementSet()
        {
            elements = new List<Element>();
            evenCount = 0;
        }
        //add element to set
        public void PutElement(Element element)
        {
            if (!elements.Any(e => e.Value == element.Value))
            {
                elements.Add(element);
                if (element.Value % 2 == 0) evenCount++;
            }
        }
        //remove element from set
        public bool RemoveElement(Element element)
        {
            var existingElement = elements.FirstOrDefault(e => e.Value == element.Value);
            try
            {
                if (existingElement == null)
                {
                    throw new NonExistentElementException();

                }
                else
                {
                    elements.Remove(existingElement);
                    if (element.Value % 2 == 0) evenCount--;
                    return true;
                }
            }
            catch (NonExistentElementException)
            {
                return false;
            }
            
            
            
        }
        //check if set is empty

        public bool CheckEmpty()
        {
            return !elements.Any();
        }
        //check if set has any elements

        public bool CheckFull()
        {
            return elements.Any();
        }
        //return random element from set
        public Element ReturnRandom()
        {
            Random rand = new Random();
            return elements[rand.Next(elements.Count)];
        }
        //return all elements in set
        public List<Element> GetElements()
        {
            return elements;
        }
        //return count of even elements in set
        public int getEvenCount()
        {
            return evenCount;
        }

    }
    public class Element
    {

        public int Value;
        //initiate element
        public Element(int value)
        {
            Value = value;
        }
        public static Element ReadElement()
        {
            Console.WriteLine("Enter element value:");
            try
            {
                int value = int.Parse(Console.ReadLine());
                return new Element(value);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid input, please enter a number");
                return ReadElement();
            }
        }



    }
}