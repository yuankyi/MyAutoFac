using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutoFac
{
    interface IA
    {

    }

    class CA : IA
    {
        public CB cbtemp;
        private CB _cb;

        public CA()
        {
            Console.WriteLine("ca created without cb");
        }

        public CA(string ca)
        {
            Console.WriteLine("ca created with string " + ca);
        }

        public CA(CB cb)
        {
            this._cb = cb;
            Console.WriteLine("ca created with cb");
        }

        public CA(CB cb1, CB cb2)
        {
            Console.WriteLine("ca created with cb1 and cb2");
        }
    }

    class CALambda : IA
    {
        public CALambda(string ca)
        {
            Console.WriteLine("ca lambda created with string " + ca);
        }
    }


    interface IB
    {

    }

    class CB : IB
    {
        private string _msg;

        public string cbString;

        public CB()
        {
            Console.WriteLine("cb created");
        }

        public CB(string msg)
        {
            this._msg = msg;
            Console.WriteLine("cb created with " + msg);
        }

        public override string ToString()
        {
            return _msg;
        }
    }

    class CBLambdaAtRegistration : IB
    {
        public CBLambdaAtRegistration(string msg)
        {
            Console.WriteLine("cb lambda created with " + msg);
        }
    }

    class CBLambdaAtResolution : IB
    {
        public CBLambdaAtResolution(string msg)
        {
            Console.WriteLine("cb lambda created with " + msg);
        }
    }


    class CBReflectionNamed : IB
    {
        public CBReflectionNamed(string msg)
        {
            Console.WriteLine("cb reflection created with " + msg);
        }
    }

    class CBReflectionTyped : IB
    {
        public CBReflectionTyped(string msg)
        {
            Console.WriteLine("cb reflection created with " + msg);
        }
    }

    class CBReflectionResolved : IB
    {
        public CBReflectionResolved(string msg)
        {
            Console.WriteLine("cb reflection created with " + msg);
        }
    }

    class CBPropertyInjection1 : IB
    {
        public CBPropertyInjection2 cb2 { get; set; }

        public CBPropertyInjection1()
        {
            Console.WriteLine("cb property injection 1 created ");
        }
    }

    class CBPropertyInjection2 : IB
    {
        public CBPropertyInjection1 cb1 { get; set; }

        public CBPropertyInjection2()
        {
            Console.WriteLine("cb property injection 2 created ");
        }
    }

    class CBPropertyInjection3 : IB
    {
        private CBPropertyInjection1 _cb1 { get; set; }

        public CBPropertyInjection3()
        {
            Console.WriteLine("cb property injection 3 created ");
        }

        public void SetCBPropertyInjection1(CBPropertyInjection1 cb1)
        {
            this._cb1 = cb1;
        }
    }

    class CBResolveOptional : IB
    {

    }
}
