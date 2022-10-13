using System;
namespace ex2
{
    public class ContactBL
    {
        string ExecutorFactory(int a)
        {
            BaseExecutor obj;

            if (a == 1)
            {
                obj = new Option1();
            }
            else if (a == 2)
            {
                obj = new Option2();
            }

            else if (a == 3)
            {
                obj = new Option3();
            }
            else
                return "non of option";

            return obj.Execute(1);
        }
        public string ExecuteAgeLogic(int a)
        {
            return ExecutorFactory(a);
        }
    }
}

