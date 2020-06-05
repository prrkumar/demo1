﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleApp1
{
    public interface IProduct
    {
        string ProcessPayment();
    }

    public class PhysicalProduct : IProduct
    {
        public string ProcessPayment()
        {
            //throw new NotImplementedException("Not Implemented");
            return ("Generate a packing slip for shipping!");
        }
    }

    public class Book : IProduct
    {
        public string ProcessPayment()
        {
            //throw new NotImplementedException("Not Implemented");
            return ("Generate a packing slip for shipping!");
        }
    }

    public class NewMembership : IProduct
    {
        public string ProcessPayment()
        {
            throw new NotImplementedException("Not Implemented");
            //return ("Generate a packing slip for shipping!");
        }
    }

    public class UpgradeMembership : IProduct
    {
        public string ProcessPayment()
        {
            throw new NotImplementedException("Not Implemented");
            //return ("Generate a packing slip for shipping!");
        }
    }

    public class Video : IProduct
    {
        public string ProcessPayment()
        {
            throw new NotImplementedException("Not Implemented");
            //return ("Generate a packing slip for shipping!");
        }
    }
}
