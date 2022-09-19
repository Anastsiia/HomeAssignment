using System;
namespace ex2
{
    abstract class BaseExecutor : IExecute
    {
        public virtual string Execute(int a)
        {
            return "default";
        }
    }

    class Option1 : BaseExecutor
    {

        public override string Execute(int a)
        {
            return "option 1";
        }
    }

    class Option2 : BaseExecutor
    {

        public override string Execute(int a)
        {
            return "option 2";
        }
    }

    class Option3 : BaseExecutor
    {

        public override string Execute(int a)
        {
            return "option 1\noption 2";
        }
    }
}
