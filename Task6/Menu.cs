namespace Task6
{
    class Menu
    {
        ElementSet elements = new ElementSet();

        public void initSet()
        {
            elements = new ElementSet();
        }

        public void Run()
        {
            int v;
            do
            {
                v = GetMenuPoint();
                switch (v)
                {
                    case 1:
                        putElement();
                        break;
                    case 2:
                        removeElement();
                        break;
                    case 3:
                        checkEmpty();
                        break;
                    case 4:
                        checkFull();
                        break;
                    case 5:
                        returnRandom();
                        break;
                    case 6:
                        returnEvenNumber();
                        break;
                    case 7:
                        printSet();
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            } while (v != 0);
        }
        private static int GetMenuPoint()
        {
            int v;
            do
            {
                Console.WriteLine("\n********************************");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Put in element");
                Console.WriteLine("2. Remove element");
                Console.WriteLine("3. Check if empty");
                Console.WriteLine("4. Check if full");
                Console.WriteLine("5. Return random element");
                Console.WriteLine("6. Return the number of even elements");
                Console.WriteLine("7. Print set");
                Console.WriteLine("****************************************");

                try
                {
                    v = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException) { v = -1; }
            } while (v < 0 || v > 7);
            return v;
        }
        private void putElement()
        {
            Console.WriteLine("Element to put in");
            Element e = Element.ReadElement();
            elements.PutElement(e);
        }
        private void removeElement()
        {
            Element e = Element.ReadElement();
            bool result = elements.RemoveElement(e);
            if (result)
            {
                Console.WriteLine("Element removed.");

            }
            else
            {
                Console.WriteLine("Element not found");
            }

        }
        private void checkEmpty()
        {
            bool isEmpty = elements.CheckEmpty();
            if (isEmpty)
            {
                Console.WriteLine("Set is empty.");
            }
            else
            {
                Console.WriteLine("Set is not empty.");
            }
        }
        private void checkFull()
        {
            bool isFull = elements.CheckFull();
            if (isFull)
            {
                Console.WriteLine("Set has elements");
            }
            else
            {
                Console.WriteLine("Set doesn't have elements.");
            }
        }
        private void returnRandom()
        {
            if (elements.CheckEmpty())
            {
                Console.WriteLine("No elements in the set");
                return;
            }
            Console.WriteLine("A random element: " + elements.ReturnRandom().Value);
        }
        private void returnEvenNumber()
        {
            Console.WriteLine("Number of even elements:" + elements.getEvenCount());
        }
        private void printSet()
        {
            foreach (var element in elements.GetElements())
            {
                Console.Write(element.Value + " ");
            }

        }

    }
}
