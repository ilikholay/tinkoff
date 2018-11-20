using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class ObjectA
    {
        public int id;
        public string field;
        public string fieldValue;

        public ObjectA(int id, string field, string fieldValue)
        {
            this.id = id;
            this.field = field;
            this.fieldValue = fieldValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ObjectA> A = new List<ObjectA>();
            List<ObjectA> B = new List<ObjectA>();

            A.Add(new ObjectA(1, "field1", "value1"));
            A.Add(new ObjectA(2, "field2", "value2"));
            A.Add(new ObjectA(3, "field3", "value3"));
            A.Add(new ObjectA(4, "field4", "value4"));

            B.Add(new ObjectA(1, "field1", "value1"));
            B.Add(new ObjectA(2, "otherField", "value2"));
            B.Add(new ObjectA(3, "field3", "otherValue"));
            B.Add(new ObjectA(4, "otherField", "otherValue"));
            
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i].field != B[i].field)
                {
                    Console.WriteLine(String.Format("Для id {0} не совпало следующее: Поле field => ожидаемое значение {1}, текущее {2}. ", (i + 1), A[i].field, B[i].field));
                }
                if (A[i].fieldValue != B[i].fieldValue)
                {
                    Console.WriteLine(String.Format("Для id {0} не совпало следующее: Поле fieldValue  => ожидаемое значение {1}, текущее {2}. ", (i + 1), A[i].fieldValue, B[i].fieldValue));
                }
            }
        }
    }
}
