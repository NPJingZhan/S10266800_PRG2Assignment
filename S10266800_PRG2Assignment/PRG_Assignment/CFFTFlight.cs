﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10266800H
// Student Name : Sew Jing Zhan
//==========================================================

namespace PRG_Assignment
{
    internal class CFFTFlight : Flight
    {
        public double RequestFee { get; set; }
        public CFFTFlight(double requestFee, string flightnum, string origin, string destination, DateTime expectedtime, string status) : base(flightnum, origin, destination, expectedtime, status)
        {
            RequestFee = requestFee;
        }
        public override string ToString()
        {
            return $"{FlightNumber,-16} {Orign,-20} {Destination,-25} {ExpectedTime}";
        }
        public override double CalculateFees()
        {
            return (base.CalculateFees() + RequestFee);
        }
    }
}

