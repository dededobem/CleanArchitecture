using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CleanArchitecture.Core.Entities
{
    public class ParkedCar
    {
        public ParkedCar(string code, string plate, DateTime date)
        {
            if (!Regex.Match(plate, @"[A-Z]{3}-[0-9]{4}").Success) throw new Exception("Invalid plate");
            Code = code;
            Plate = plate;
            Date = date;
        }

        public string Code { get; private set; }
        public string Plate { get; private set; }
        public DateTime Date { get; private set; }
    }
}
